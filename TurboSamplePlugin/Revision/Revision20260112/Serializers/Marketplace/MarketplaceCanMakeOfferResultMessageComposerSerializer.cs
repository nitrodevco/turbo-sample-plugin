using Turbo.Primitives.Messages.Outgoing.Marketplace;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Marketplace;

internal class MarketplaceCanMakeOfferResultMessageComposerSerializer(int header)
    : AbstractSerializer<MarketplaceCanMakeOfferResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketplaceCanMakeOfferResultMessageComposer message
    )
    {
        //
    }
}
