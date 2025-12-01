using Turbo.Primitives.Messages.Incoming.Room.Furniture;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Furniture;

internal class EnterOneWayDoorMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new EnterOneWayDoorMessage();
}
