using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class IgnoredUsersMessageComposerSerializer(int header)
    : AbstractSerializer<IgnoredUsersMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, IgnoredUsersMessageComposer message)
    {
        //
    }
}
