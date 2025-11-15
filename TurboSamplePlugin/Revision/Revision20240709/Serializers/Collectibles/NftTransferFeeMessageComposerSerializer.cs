using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class NftTransferFeeMessageComposerSerializer(int header)
    : AbstractSerializer<NftTransferFeeMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, NftTransferFeeMessageComposer message)
    {
        //
    }
}
