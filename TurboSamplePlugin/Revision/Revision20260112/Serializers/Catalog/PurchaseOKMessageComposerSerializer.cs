using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog;

internal class PurchaseOKMessageComposerSerializer(int header)
    : AbstractSerializer<PurchaseOKMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PurchaseOKMessageComposer message)
    {
        CatalogOfferSerializer.SerializeAsPurchased(packet, message.Offer);
    }
}
