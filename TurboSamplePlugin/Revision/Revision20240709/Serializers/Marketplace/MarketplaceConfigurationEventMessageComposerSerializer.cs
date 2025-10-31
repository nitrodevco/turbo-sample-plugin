using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Marketplace;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Marketplace;

internal class MarketplaceConfigurationEventMessageComposerSerializer(int header)
    : AbstractSerializer<MarketplaceConfigurationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MarketplaceConfigurationEventMessageComposer message
    )
    {
        //
    }
}
