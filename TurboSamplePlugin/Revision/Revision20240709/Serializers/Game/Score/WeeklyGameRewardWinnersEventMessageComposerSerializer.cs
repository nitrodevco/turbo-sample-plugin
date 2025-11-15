using Turbo.Primitives.Messages.Outgoing.Game.Score;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Score;

internal class WeeklyGameRewardWinnersEventMessageComposerSerializer(int header)
    : AbstractSerializer<WeeklyGameRewardWinnersEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WeeklyGameRewardWinnersEventMessageComposer message
    )
    {
        //
    }
}
