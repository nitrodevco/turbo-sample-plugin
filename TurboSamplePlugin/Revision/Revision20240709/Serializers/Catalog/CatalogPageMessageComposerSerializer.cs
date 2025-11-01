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
        packet
            .WriteInteger(message.Page.Id)
            .WriteString(message.CatalogType.ToLegacyString())
            .WriteString(message.Page.Layout);

        CatalogPageLocalizationSerializer.Serialize(packet, message.Page);

        packet.WriteInteger(message.Offers.Count);

        foreach (var offer in message.Offers)
        {
            var products = message.OfferProducts[offer.Id];

            CatalogOfferSerializer.Serialize(packet, offer, products);
        }

        packet
            .WriteInteger(message.OfferId)
            .WriteBoolean(message.AcceptSeasonCurrencyAsCredits)
            .WriteInteger(message.FrontPageItems.Count);

        foreach (var frontPageItem in message.FrontPageItems)
            CatalogFrontPageItemSerializer.Serialize(packet, frontPageItem);
    }
}
