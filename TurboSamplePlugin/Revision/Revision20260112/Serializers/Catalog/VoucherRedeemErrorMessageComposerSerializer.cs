using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog;

internal class VoucherRedeemErrorMessageComposerSerializer(int header)
    : AbstractSerializer<VoucherRedeemErrorMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        VoucherRedeemErrorMessageComposer message
    )
    {
        //
    }
}
