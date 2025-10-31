using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class UserNameChangedMessageComposerSerializer(int header)
    : AbstractSerializer<UserNameChangedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserNameChangedMessageComposer message)
    {
        //
    }
}
