using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Marketplace;

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
