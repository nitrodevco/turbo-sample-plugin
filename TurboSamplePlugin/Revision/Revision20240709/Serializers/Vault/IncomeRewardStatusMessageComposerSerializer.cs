using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Vault;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Vault;

internal class IncomeRewardStatusMessageComposerSerializer(int header)
    : AbstractSerializer<IncomeRewardStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        IncomeRewardStatusMessageComposer message
    )
    {
        packet.WriteInteger(message.IncomeRewards.Count);

        foreach (var reward in message.IncomeRewards)
        {
            packet
                .WriteByte((byte)reward.RewardCategory)
                .WriteByte((byte)reward.RewardType)
                .WriteInteger(reward.Amount)
                .WriteString(reward.ProductCode);
        }
    }
}
