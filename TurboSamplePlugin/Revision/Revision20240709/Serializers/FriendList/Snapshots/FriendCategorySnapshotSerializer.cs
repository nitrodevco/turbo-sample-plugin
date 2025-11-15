using Turbo.Primitives.Packets;
using Turbo.Primitives.Snapshots.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList.Snapshots;

internal class FriendCategorySnapshotSerializer
{
    public static void Serialize(IServerPacket packet, FriendCategorySnapshot message)
    {
        packet.WriteInteger(message.Id);
        packet.WriteString(message.Name);
    }
}
