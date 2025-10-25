using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class MiniMailUnreadCountMessageSerializer(int header)
    : AbstractSerializer<MiniMailUnreadCountMessage>(header)
{
    protected override void Serialize(IServerPacket packet, MiniMailUnreadCountMessage message)
    {
        packet.WriteInteger(message.UnreadCount);
    }
}
