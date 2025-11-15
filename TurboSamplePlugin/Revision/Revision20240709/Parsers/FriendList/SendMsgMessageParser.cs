using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;

public class SendMsgMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new SendMsgMessage
        {
            ChatId = packet.PopInt(),
            Message = packet.PopString(),
            ConfirmationId = packet.PopInt(),
        };
}
