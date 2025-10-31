using System.Linq;
using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class CatalogPageMessageComposerSerializer(int header)
    : AbstractSerializer<CatalogPageMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CatalogPageMessageComposer message)
    {
        var page = message.Catalog.PagesById[message.PageId];

        if (page is not null)
        {
            packet
                .WriteInteger(page.Id)
                .WriteString(message.Catalog.CatalogType.ToLegacyString())
                .WriteString(page.Layout);

            CatalogPageLocalizationSerializer.Serialize(packet, page);

            if (message.Catalog.PageOffers.TryGetValue(page.Id, out var offers))
            {
                packet.WriteInteger(offers.Length);

                foreach (var offerId in offers)
                {
                    var offer = message.Catalog.OffersById[offerId];
                    var products = message
                        .Catalog.OfferProducts[offerId]
                        .Select(x => message.Catalog.ProductsById[x])
                        .ToList();

                    CatalogOfferSerializer.Serialize(packet, offer, products, message.Furniture);
                }
            }
            else
            {
                packet.WriteInteger(0);
            }

            packet
                .WriteInteger(message.OfferId)
                .WriteBoolean(message.AcceptSeasonCurrencyAsCredits)
                .WriteInteger(0); // frontpage items
        }
    }
}
