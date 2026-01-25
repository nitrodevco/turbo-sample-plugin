using Turbo.Primitives.Messages.Incoming.Room.Furniture;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Room.Furniture;

internal class RoomDimmerGetPresetsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RoomDimmerGetPresetsMessage();
}
