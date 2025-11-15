using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class CollectibleMintTokenCountMessageComposerSerializer(int header)
    : AbstractSerializer<CollectibleMintTokenCountMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CollectibleMintTokenCountMessageComposer message
    )
    {
        //
    }
}
