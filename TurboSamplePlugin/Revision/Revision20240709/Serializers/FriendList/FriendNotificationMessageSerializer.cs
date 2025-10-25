using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

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
