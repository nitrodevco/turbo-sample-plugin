using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class CommunityGoalHallOfFameMessageComposerSerializer(int header)
    : AbstractSerializer<CommunityGoalHallOfFameMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CommunityGoalHallOfFameMessageComposer message
    )
    {
        //
    }
}
