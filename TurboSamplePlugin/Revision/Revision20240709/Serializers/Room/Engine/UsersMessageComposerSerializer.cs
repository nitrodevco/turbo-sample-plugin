using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class UsersMessageComposerSerializer(int header)
    : AbstractSerializer<UsersMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, UsersMessageComposer message)
    {
        packet.WriteInteger(message.Avatars.Length);

        foreach (var avatar in message.Avatars)
        {
            RoomAvatarSerializer.Serialize(packet, avatar);
        }
    }
}
