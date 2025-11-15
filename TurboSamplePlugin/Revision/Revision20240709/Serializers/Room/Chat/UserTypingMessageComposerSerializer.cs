using Turbo.Primitives.Messages.Outgoing.Room.Chat;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Chat;

internal class UserTypingMessageComposerSerializer(int header)
    : AbstractSerializer<UserTypingMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UserTypingMessageComposer message)
    {
        //
    }
}
