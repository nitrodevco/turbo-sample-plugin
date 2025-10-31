using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

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
