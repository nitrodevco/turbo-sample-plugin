using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.RoomSettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;

internal class GetBannedUsersFromRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetBannedUsersFromRoomMessage { RoomId = packet.PopInt() };
}
