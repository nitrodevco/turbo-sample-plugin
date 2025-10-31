using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

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
