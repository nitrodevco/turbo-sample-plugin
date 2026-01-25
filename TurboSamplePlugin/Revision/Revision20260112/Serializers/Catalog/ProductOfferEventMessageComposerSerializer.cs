using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog;

internal class ProductOfferEventMessageComposerSerializer(int header)
    : AbstractSerializer<ProductOfferEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ProductOfferEventMessageComposer message
    )
    {
        CatalogOfferSerializer.Serialize(packet, message.Offer);
    }
}
