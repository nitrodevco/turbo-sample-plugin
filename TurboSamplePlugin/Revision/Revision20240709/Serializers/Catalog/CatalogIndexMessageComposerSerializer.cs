using System.Linq;
using Turbo.Primitives.Catalog.Enums;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;
using Turbo.Primitives.Snapshots.Catalog;
using Turbo.Primitives.Snapshots.Catalog.Extensions;
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

        var offers = snapshot.GetOfferIdsByPageId(page.Id);

        packet.WriteInteger(offers.Length);

        foreach (var offerId in offers)
            packet.WriteInteger(offerId);

        var children = snapshot
            .GetChildPageIdsByPageId(page.Id)
            .Select(snapshot.GetPageById)
            .ToArray();

        packet.WriteInteger(children.Length);

        foreach (var child in children)
            SerializePage(packet, snapshot, child);
    }
}
