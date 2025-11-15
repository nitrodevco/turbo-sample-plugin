using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;

internal class GetMessengerHistoryMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetMessengerHistoryMessage { ChatId = packet.PopInt(), Message = packet.PopString() };
}
