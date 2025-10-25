using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class HabboSearchResultMessageSerializer(int header)
    : AbstractSerializer<HabboSearchResultMessage>(header)
{
    protected override void Serialize(IServerPacket packet, HabboSearchResultMessage message)
    {
        packet.WriteInteger(message.Friends.Count);

        foreach (var friend in message.Friends)
        {
            MessengerSearchResultSnapshotSerializer.Serialize(packet, friend);
        }

        packet.WriteInteger(message.Others.Count);

        foreach (var other in message.Others)
        {
            MessengerSearchResultSnapshotSerializer.Serialize(packet, other);
        }
    }
}
