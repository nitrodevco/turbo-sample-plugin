using Turbo.Primitives.Packets;
using Turbo.Primitives.Snapshots.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList.Snapshots;

internal class MessengerFriendSnapshotSerializer
{
    public static void Serialize(IServerPacket packet, MessengerFriendSnapshot message)
    {
        packet.WriteInteger((int)message.Id);
        packet.WriteString(message.Name);
        packet.WriteInteger((int)message.Gender);
        packet.WriteBoolean(message.Online);
        packet.WriteBoolean(message.FollowingAllowed);
        packet.WriteString(message.Figure);
        packet.WriteInteger(message.CategoryId);
        packet.WriteString(message.Motto);
        packet.WriteString(message.FacebookId);
        packet.WriteBoolean(message.PersistedMessageUser);
        packet.WriteBoolean(message.VipMember);
        packet.WriteBoolean(message.PocketHabboUser);
        packet.WriteShort(message.RelationshipStatus);
    }
}
