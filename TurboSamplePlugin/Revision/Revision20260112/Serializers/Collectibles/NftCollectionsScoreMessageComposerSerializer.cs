using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Collectibles;

internal class NftCollectionsScoreMessageComposerSerializer(int header)
    : AbstractSerializer<NftCollectionsScoreMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NftCollectionsScoreMessageComposer message
    )
    {
        //
    }
}
