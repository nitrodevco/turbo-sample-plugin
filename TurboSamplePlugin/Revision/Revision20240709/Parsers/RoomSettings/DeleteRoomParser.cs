using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.RoomSettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;

public class DeleteRoomParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new DeleteRoomMessage { RoomId = packet.PopInt() };
}
