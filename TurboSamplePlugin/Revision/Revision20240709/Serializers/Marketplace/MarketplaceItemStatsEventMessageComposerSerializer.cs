using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Marketplace;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketplaceItemStatsEventMessageComposerSerializer(int header)
    : AbstractSerializer<MarketplaceItemStatsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketplaceItemStatsEventMessageComposer message
    )
    {
        //
    }
}
