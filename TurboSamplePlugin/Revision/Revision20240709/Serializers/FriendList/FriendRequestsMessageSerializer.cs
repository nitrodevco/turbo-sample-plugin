using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;
using Turbo.Primitives.Snapshots.FriendList;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class FriendRequestsMessageSerializer(int header)
    : AbstractSerializer<FriendRequestsMessage>(header)
{
    protected override void Serialize(IServerPacket packet, FriendRequestsMessage message)
    {
        int totalRequests = message.Requests.Count;

        packet.WriteInteger(totalRequests);
        packet.WriteInteger(totalRequests);

        foreach (var request in message.Requests)
        {
            FriendRequestSnapshotSerializer.Serialize(packet, request);
        }
    }
}
