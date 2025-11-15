using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class NewFriendRequestMessageSerializer(int header)
    : AbstractSerializer<NewFriendRequestMessage>(header)
{
    protected override void Serialize(IServerPacket packet, NewFriendRequestMessage message)
    {
        FriendRequestSnapshotSerializer.Serialize(packet, message.Request);
    }
}
