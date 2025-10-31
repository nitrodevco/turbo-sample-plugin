using System.Collections.Generic;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Catalog;
using Turbo.Primitives.Snapshots.Furniture;
using Turbo.Primitives.Snapshots.Furniture.Extensions;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

internal class CatalogOfferSerializer
{
    public static void Serialize(
        IServerPacket packet,
        CatalogOfferSnapshot offer,
        List<CatalogProductSnapshot> products,
        FurnitureSnapshot furniture
    )
    {
        packet
            .WriteInteger(offer.Id)
            .WriteString(offer.LocalizationId)
            .WriteBoolean(offer.Rentable)
            .WriteInteger(offer.CostCredits)
            .WriteInteger(offer.CostCurrency)
            .WriteInteger(offer.CurrencyType ?? -1)
            .WriteInteger(offer.CostSilver)
            .WriteBoolean(offer.CanGift)
            .WriteInteger(products.Count);

        foreach (var product in products)
        {
            var furniDef = furniture.GetDefinitionById(product.FurniDefinitionId);

            CatalogProductSerializer.Serialize(packet, product, furniDef);
        }

        packet
            .WriteInteger(offer.ClubLevel)
            .WriteBoolean(offer.CanBundle)
            .WriteBoolean(false) // unknownBoolean
            .WriteString(string.Empty); // previewImage
    }
}
