using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

internal class CatalogPageSnapshotSerializer
{
    public static void Serialize(IServerPacket packet, CatalogPageSnapshot message)
    {
        packet
            .WriteBoolean(message.Visible)
            .WriteInteger(message.Icon)
            .WriteInteger(message.Id)
            .WriteString(message.Name)
            .WriteString(message.Localization);
    }
}
