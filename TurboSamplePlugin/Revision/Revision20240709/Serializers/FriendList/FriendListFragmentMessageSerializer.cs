using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class FriendListFragmentMessageSerializer(int header)
    : AbstractSerializer<FriendListFragmentMessage>(header)
{
    protected override void Serialize(IServerPacket packet, FriendListFragmentMessage message)
    {
        packet.WriteInteger(message.TotalFragments);
        packet.WriteInteger(message.FragmentIndex);
        packet.WriteInteger(message.Fragment.Count);

        foreach (var friend in message.Fragment)
        {
            MessengerFriendSnapshotSerializer.Serialize(packet, friend);
        }
    }
}
