using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Layout;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Layout;

internal class GetRoomEntryTileMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetRoomEntryTileMessage();
}
