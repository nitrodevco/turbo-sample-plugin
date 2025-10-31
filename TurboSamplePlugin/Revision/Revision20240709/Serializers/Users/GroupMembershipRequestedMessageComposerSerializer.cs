using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GroupMembershipRequestedMessageComposerSerializer(int header)
    : AbstractSerializer<GroupMembershipRequestedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GroupMembershipRequestedMessageComposer message
    )
    {
        //
    }
}
