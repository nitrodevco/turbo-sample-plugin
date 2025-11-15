using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class ConsoleMessageHistoryMessageSerializer(int header)
    : AbstractSerializer<ConsoleMessageHistoryMessage>(header)
{
    protected override void Serialize(IServerPacket packet, ConsoleMessageHistoryMessage message)
    {
        packet.WriteInteger(message.ChatId);
        packet.WriteInteger(message.Messages.Count);

        foreach (var consoleMessage in message.Messages)
        {
            packet.WriteInteger((int)consoleMessage.SenderId);
            packet.WriteString(consoleMessage.SenderName);
            packet.WriteString(consoleMessage.SenderFigure);
            packet.WriteString(consoleMessage.Message);
            packet.WriteInteger(consoleMessage.SecondsSinceSent);
            packet.WriteString(consoleMessage.MessageId);
        }
    }
}
