using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class GetGuestRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetGuestRoomMessage
        {
            RoomId = packet.PopInt(),
            EnterRoom = packet.PopInt() == 1,
            RoomForward = packet.PopInt() == 1,
        };
}
