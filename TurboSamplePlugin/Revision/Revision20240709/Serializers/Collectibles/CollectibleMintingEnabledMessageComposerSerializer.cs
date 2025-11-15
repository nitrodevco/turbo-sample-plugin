using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class CollectibleMintingEnabledMessageComposerSerializer(int header)
    : AbstractSerializer<CollectibleMintingEnabledMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CollectibleMintingEnabledMessageComposer message
    )
    {
        //
    }
}
