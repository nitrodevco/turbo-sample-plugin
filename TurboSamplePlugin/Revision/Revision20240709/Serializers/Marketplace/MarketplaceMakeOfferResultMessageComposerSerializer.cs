using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Marketplace;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketplaceMakeOfferResultMessageComposerSerializer(int header)
    : AbstractSerializer<MarketplaceMakeOfferResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketplaceMakeOfferResultMessageComposer message
    )
    {
        //
    }
}
