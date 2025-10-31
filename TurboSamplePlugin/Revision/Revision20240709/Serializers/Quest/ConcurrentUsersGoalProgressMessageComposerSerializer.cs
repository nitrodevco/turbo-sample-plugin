using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Quest;

internal class ConcurrentUsersGoalProgressMessageComposerSerializer(int header)
    : AbstractSerializer<ConcurrentUsersGoalProgressMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ConcurrentUsersGoalProgressMessageComposer message
    )
    {
        //
    }
}
