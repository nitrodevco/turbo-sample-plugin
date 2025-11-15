using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Action;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Action;

internal class UnbanUserFromRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UnbanUserFromRoomMessage();
}
