using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class FollowFriendFailedMessageSerializer(int header)
    : AbstractSerializer<FollowFriendFailedMessage>(header)
{
    protected override void Serialize(IServerPacket packet, FollowFriendFailedMessage message)
    {
        packet.WriteInteger((int)message.ErrorCode);
    }
}
