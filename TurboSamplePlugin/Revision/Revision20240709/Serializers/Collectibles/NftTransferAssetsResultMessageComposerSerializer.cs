using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

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
