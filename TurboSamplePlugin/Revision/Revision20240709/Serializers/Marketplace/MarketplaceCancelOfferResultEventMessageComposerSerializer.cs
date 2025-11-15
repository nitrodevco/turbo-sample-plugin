using Turbo.Primitives.Messages.Outgoing.Marketplace;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketplaceCancelOfferResultEventMessageComposerSerializer(int header)
    : AbstractSerializer<MarketplaceCancelOfferResultEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketplaceCancelOfferResultEventMessageComposer message
    )
    {
        //
    }
}
