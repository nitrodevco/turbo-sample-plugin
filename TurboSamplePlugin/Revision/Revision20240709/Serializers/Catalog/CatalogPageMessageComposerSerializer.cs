using Turbo.Primitives.Catalog.Enums;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;
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

        packet.WriteInteger(message.Offers.Length);

        foreach (var offer in message.Offers)
            CatalogOfferSerializer.Serialize(packet, offer);

        packet
            .WriteInteger(message.OfferId)
            .WriteBoolean(message.AcceptSeasonCurrencyAsCredits)
            .WriteInteger(message.FrontPageItems.Length);

        foreach (var frontPageItem in message.FrontPageItems)
            CatalogFrontPageItemSerializer.Serialize(packet, frontPageItem);
    }
}
