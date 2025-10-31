using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

internal class CatalogFrontPageItemSerializer
{
    public static void Serialize(IServerPacket packet, CatalogFrontPageItemSnapshot message)
    {
        packet
            .WriteInteger(message.Position)
            .WriteString(message.ItemName)
            .WriteString(message.ItemPromoImage)
            .WriteInteger((int)message.Type);

        switch (message.Type)
        {
            case CatalogFrontPageItemTypeEnum.Default:
                packet.WriteString(message.CatalogPageLocation ?? string.Empty);
                break;
            case CatalogFrontPageItemTypeEnum.One:
                packet.WriteInteger(message.ProductOfferId ?? 0);
                break;
            case CatalogFrontPageItemTypeEnum.Two:
                packet.WriteString(message.ProductCode ?? string.Empty);
                break;
        }

        packet.WriteInteger(message.ExpiresInSeconds);
    }
}
