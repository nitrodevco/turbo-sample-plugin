using Turbo.Primitives.Packets;
using Turbo.Primitives.Snapshots.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

internal class CatalogPageLocalizationSerializer
{
    public static void Serialize(IServerPacket packet, CatalogPageSnapshot message)
    {
        packet.WriteInteger(message.ImageData.Count);

        foreach (var data in message.ImageData)
        {
            packet.WriteString(data);
        }

        packet.WriteInteger(message.TextData.Count);

        foreach (var data in message.TextData)
        {
            packet.WriteString(data);
        }
    }
}
