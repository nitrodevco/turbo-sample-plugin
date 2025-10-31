using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Vault;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Vault;

internal class IncomeRewardClaimResponseMessageComposerSerializer(int header)
    : AbstractSerializer<IncomeRewardClaimResponseMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        IncomeRewardClaimResponseMessageComposer message
    )
    {
        //
    }
}
