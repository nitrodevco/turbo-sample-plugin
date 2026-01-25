using Turbo.Primitives.Messages.Incoming.Room.Layout;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Room.Layout;

internal class GetRoomEntryTileMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetRoomEntryTileMessage();
}
