using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Moderator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Moderator;

internal class GetRoomChatlogMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetRoomChatlogMessage();
}
