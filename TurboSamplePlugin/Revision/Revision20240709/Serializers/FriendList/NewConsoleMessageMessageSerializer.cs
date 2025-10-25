using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class NewConsoleMessageMessageSerializer(int header)
    : AbstractSerializer<NewConsoleMessageMessage>(header)
{
    protected override void Serialize(IServerPacket packet, NewConsoleMessageMessage message)
    {
        packet.WriteInteger(message.ChatId);
        packet.WriteString(message.Message);
        packet.WriteInteger(message.SecondsSinceSent);
        packet.WriteString(message.MessageId);
        packet.WriteInteger(message.ConfirmationId);
        packet.WriteInteger(message.SenderId);
        packet.WriteString(message.SenderName);
        packet.WriteString(message.SenderFigure);
    }
}
