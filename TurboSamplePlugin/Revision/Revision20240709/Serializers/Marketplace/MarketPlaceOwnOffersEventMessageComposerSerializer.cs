using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Marketplace;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketPlaceOwnOffersEventMessageComposerSerializer(int header)
    : AbstractSerializer<MarketPlaceOwnOffersEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketPlaceOwnOffersEventMessageComposer message
    )
    {
        //
    }
}
