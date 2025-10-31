using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class GroupDetailsChangedMessageComposerSerializer(int header)
    : AbstractSerializer<GroupDetailsChangedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GroupDetailsChangedMessageComposer message
    )
    {
        //
    }
}
