using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class CommunityGoalProgressMessageComposerSerializer(int header)
    : AbstractSerializer<CommunityGoalProgressMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CommunityGoalProgressMessageComposer message
    )
    {
        //
    }
}
