using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class AcceptFriendResultMessageSerializer(int header)
    : AbstractSerializer<AcceptFriendResultMessage>(header)
{
    protected override void Serialize(IServerPacket packet, AcceptFriendResultMessage message)
    {
        packet.WriteInteger(message.Failures.Count);

        foreach (var failure in message.Failures)
        {
            packet.WriteInteger((int)failure.SenderId);
            packet.WriteInteger((int)failure.ErrorCode);
        }
    }
}
