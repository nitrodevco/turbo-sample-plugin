using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class RoomInviteErrorMessageSerializer(int header)
    : AbstractSerializer<RoomInviteErrorMessage>(header)
{
    protected override void Serialize(IServerPacket packet, RoomInviteErrorMessage message)
    {
        packet.WriteInteger(message.ErrorCode);

        if (message.ErrorCode is 1)
        {
            packet.WriteInteger(message.FailedRecipients.Count);

            foreach (var recipient in message.FailedRecipients)
            {
                packet.WriteInteger(recipient);
            }
        }
    }
}
