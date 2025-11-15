using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class RoomInviteMessageSerializer(int header)
    : AbstractSerializer<RoomInviteMessage>(header)
{
    protected override void Serialize(IServerPacket packet, RoomInviteMessage message)
    {
        packet.WriteInteger(message.SenderId);
        packet.WriteString(message.Message);
    }
}
