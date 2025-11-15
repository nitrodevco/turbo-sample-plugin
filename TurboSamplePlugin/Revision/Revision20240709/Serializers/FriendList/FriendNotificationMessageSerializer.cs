using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class FriendNotificationMessageSerializer(int header)
    : AbstractSerializer<FriendNotificationMessage>(header)
{
    protected override void Serialize(IServerPacket packet, FriendNotificationMessage message)
    {
        packet.WriteString(message.AvatarId);
        packet.WriteInteger((int)message.TypeCode);
        packet.WriteString(message.Message);
    }
}
