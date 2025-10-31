using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Score;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Score;

internal class WeeklyGameRewardEventMessageComposerSerializer(int header)
    : AbstractSerializer<WeeklyGameRewardEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WeeklyGameRewardEventMessageComposer message
    )
    {
        //
    }
}
