using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.FriendList.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.FriendList;

internal class NewFriendRequestMessageSerializer(int header)
    : AbstractSerializer<NewFriendRequestMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, NewFriendRequestMessageComposer message)
    {
        FriendRequestSnapshotSerializer.Serialize(packet, message.Request);
    }
}
