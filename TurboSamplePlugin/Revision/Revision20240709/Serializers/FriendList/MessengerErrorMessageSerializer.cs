using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class MessengerErrorMessageSerializer(int header)
    : AbstractSerializer<MessengerErrorMessage>(header)
{
    protected override void Serialize(IServerPacket packet, MessengerErrorMessage message)
    {
        packet.WriteInteger(message.ClientMessageId);
        packet.WriteInteger((int)message.ErrorCode);
    }
}
