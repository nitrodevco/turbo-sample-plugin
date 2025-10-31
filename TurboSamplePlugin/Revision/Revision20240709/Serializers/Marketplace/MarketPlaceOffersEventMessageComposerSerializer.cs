using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Marketplace;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketPlaceOffersEventMessageComposerSerializer(int header)
    : AbstractSerializer<MarketPlaceOffersEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketPlaceOffersEventMessageComposer message
    )
    {
        //
    }
}
