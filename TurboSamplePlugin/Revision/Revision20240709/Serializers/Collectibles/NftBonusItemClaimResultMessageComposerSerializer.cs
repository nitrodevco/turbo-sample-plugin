using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class NftBonusItemClaimResultMessageComposerSerializer(int header)
    : AbstractSerializer<NftBonusItemClaimResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NftBonusItemClaimResultMessageComposer message
    )
    {
        //
    }
}
