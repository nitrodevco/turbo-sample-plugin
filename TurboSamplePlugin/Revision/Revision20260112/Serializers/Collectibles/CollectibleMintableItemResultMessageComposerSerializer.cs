using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Collectibles;

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
