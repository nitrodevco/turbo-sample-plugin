using System;
using System.Linq;
using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Snapshots.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class CatalogIndexMessageComposerSerializer(int header)
    : AbstractSerializer<CatalogIndexMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CatalogIndexMessageComposer message)
    {
        var rootPage = message.Catalog.PagesById.First(x => x.Value.ParentId == -1).Value;

        if (rootPage is null)
            return;

        SerializePage(packet, message.Catalog, rootPage.Id, rootPage);

        packet
            .WriteBoolean(message.NewAdditionsAvailable)
            .WriteString(message.Catalog.CatalogType.ToLegacyString());

        Console.WriteLine(packet.ToString());
    }

    private static void SerializePage(
        IServerPacket packet,
        CatalogSnapshot snapshot,
        int pageId,
        CatalogPageSnapshot page
    )
    {
        CatalogPageSnapshotSerializer.Serialize(packet, page);

        if (snapshot.PageOffers.TryGetValue(pageId, out var offers))
        {
            packet.WriteInteger(offers.Length);

            foreach (var offerId in offers)
            {
                packet.WriteInteger(offerId);
            }
        }
        else
        {
            packet.WriteInteger(0);
        }

        if (snapshot.PageChildren.TryGetValue(pageId, out var children))
        {
            packet.WriteInteger(children.Length);

            foreach (var childId in children)
            {
                var childPage = snapshot.PagesById[childId];

                SerializePage(packet, snapshot, childId, childPage);
            }
        }
        else
        {
            packet.WriteInteger(0);
        }
    }
}
