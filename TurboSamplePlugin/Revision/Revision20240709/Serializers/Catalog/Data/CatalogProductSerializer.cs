using Turbo.Contracts.Enums.Furniture;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Catalog;
using Turbo.Primitives.Snapshots.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

internal class CatalogProductSerializer
{
    public static void Serialize(
        IServerPacket packet,
        CatalogProductSnapshot product,
        FurnitureDefinitionSnapshot furniDef
    )
    {
        packet.WriteString(product.ProductType.ToLegacyString());

        if (product.ProductType is not ProductTypeEnum.Badge)
        {
            packet
                .WriteInteger(furniDef?.SpriteId ?? -1)
                .WriteString(product.ExtraParam ?? string.Empty)
                .WriteInteger(product.Quantity)
                .WriteBoolean(product.UniqueSize > 0);

            if (product.UniqueSize > 0)
            {
                packet.WriteInteger(product.UniqueSize).WriteInteger(product.UniqueRemaining);
            }
        }
        else
        {
            packet.WriteString(product.ExtraParam ?? string.Empty);
        }
    }
}
