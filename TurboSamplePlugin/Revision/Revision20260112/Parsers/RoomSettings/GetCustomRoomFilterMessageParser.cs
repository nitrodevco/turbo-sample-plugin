using Turbo.Primitives.Messages.Incoming.RoomSettings;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.RoomSettings;

internal class GetCustomRoomFilterMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetCustomRoomFilterMessage { RoomId = packet.PopInt() };
}
