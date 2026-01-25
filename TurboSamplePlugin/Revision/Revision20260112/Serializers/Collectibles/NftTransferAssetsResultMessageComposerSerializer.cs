using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Collectibles;

internal class NftTransferAssetsResultMessageComposerSerializer(int header)
    : AbstractSerializer<NftTransferAssetsResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NftTransferAssetsResultMessageComposer message
    )
    {
        //
    }
}
