using System.Collections.Generic;
using Turbo.Primitives.Catalog.Snapshots;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

internal class CatalogOfferSerializer
{
    public static void Serialize(
        IServerPacket packet,
        CatalogOfferSnapshot offer,
        List<CatalogProductSnapshot> offerProducts
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
            .WriteInteger(offerProducts.Count);

        foreach (var product in offerProducts)
            CatalogProductSerializer.Serialize(packet, product);

        packet
            .WriteInteger(offer.ClubLevel)
            .WriteBoolean(offer.CanBundle)
            .WriteBoolean(false) // unknownBoolean
            .WriteString(string.Empty); // previewImage
    }
}
