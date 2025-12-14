using System.Collections.Generic;
using Turbo.Primitives.Catalog.Enums;
using Turbo.Primitives.Catalog.Snapshots;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class CatalogIndexMessageComposerSerializer(int header)
    : AbstractSerializer<CatalogIndexMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CatalogIndexMessageComposer message)
    {
        var rootPage = message.Catalog.PagesById[message.Catalog.RootPageId];

        if (rootPage is null)
            return;

        SerializePage(packet, message.Catalog, rootPage);

        packet
            .WriteBoolean(message.NewAdditionsAvailable)
            .WriteString(message.Catalog.CatalogType.ToLegacyString());
    }

    private static void SerializePage(
        IServerPacket packet,
        CatalogSnapshot snapshot,
        CatalogPageSnapshot page
    )
    {
        CatalogPageSnapshotSerializer.Serialize(packet, page);

        if (snapshot.PageOfferIds.TryGetValue(page.Id, out var offerIds))
        {
            packet.WriteInteger(offerIds.Length);

            foreach (var offerId in offerIds)
                packet.WriteInteger(offerId);
        }
        else
            packet.WriteInteger(0);

        List<CatalogPageSnapshot> children = [];

        if (snapshot.PageChildrenIds.TryGetValue(page.Id, out var childIds))
        {
            foreach (var childId in childIds)
            {
                if (snapshot.PagesById.TryGetValue(childId, out var childPage))
                    children.Add(childPage);
            }
        }

        packet.WriteInteger(children.Count);

        foreach (var child in children)
            SerializePage(packet, snapshot, child);
    }
}
