using System.Linq;
using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Snapshots.Catalog.Extensions;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class CatalogPageMessageComposerSerializer(int header)
    : AbstractSerializer<CatalogPageMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CatalogPageMessageComposer message)
    {
        var page = message.Catalog.GetPageById(message.PageId);

        if (page is null)
            return;

        packet
            .WriteInteger(page.Id)
            .WriteString(message.Catalog.CatalogType.ToLegacyString())
            .WriteString(page.Layout);

        CatalogPageLocalizationSerializer.Serialize(packet, page);

        var offers = message
            .Catalog.GetOfferIdsByPageId(page.Id)
            .Select(message.Catalog.GetOfferById)
            .Where(x => x != null)
            .ToList();

        packet.WriteInteger(offers.Count);

        foreach (var offer in offers)
        {
            var products = message
                .Catalog.GetProductIdsByOfferId(offer.Id)
                .Select(message.Catalog.GetProductById)
                .Where(x => x != null)
                .ToList();

            CatalogOfferSerializer.Serialize(packet, offer, products, message.Furniture);
        }

        packet
            .WriteInteger(message.OfferId)
            .WriteBoolean(message.AcceptSeasonCurrencyAsCredits)
            .WriteInteger(message.FrontPageItems.Count);

        foreach (var frontPageItem in message.FrontPageItems)
            CatalogFrontPageItemSerializer.Serialize(packet, frontPageItem);
    }
}
