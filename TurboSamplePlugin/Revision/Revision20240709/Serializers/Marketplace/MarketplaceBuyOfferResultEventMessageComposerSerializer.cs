using Turbo.Primitives.Messages.Outgoing.Marketplace;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketplaceBuyOfferResultEventMessageComposerSerializer(int header)
    : AbstractSerializer<MarketplaceBuyOfferResultEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketplaceBuyOfferResultEventMessageComposer message
    )
    {
        //
    }
}
