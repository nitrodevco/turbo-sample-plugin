using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class CollectibleMintableItemResultMessageComposerSerializer(int header)
    : AbstractSerializer<CollectibleMintableItemResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CollectibleMintableItemResultMessageComposer message
    )
    {
        //
    }
}
