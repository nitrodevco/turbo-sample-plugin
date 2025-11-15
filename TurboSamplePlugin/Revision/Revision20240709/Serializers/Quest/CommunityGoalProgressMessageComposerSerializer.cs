using Turbo.Primitives.Messages.Outgoing.Quest;
using Turbo.Primitives.Packets;

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
