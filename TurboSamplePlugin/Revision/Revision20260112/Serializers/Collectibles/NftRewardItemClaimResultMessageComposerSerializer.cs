using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Collectibles;

internal class NftRewardItemClaimResultMessageComposerSerializer(int header)
    : AbstractSerializer<NftRewardItemClaimResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NftRewardItemClaimResultMessageComposer message
    )
    {
        //
    }
}
