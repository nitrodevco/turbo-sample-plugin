using Turbo.Primitives.Messages.Incoming.Room.Session;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Session;

internal class OpenFlatConnectionMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new OpenFlatConnectionMessage
        {
            RoomId = packet.PopInt(),
            Password = packet.PopString(),
            Unknown1 = packet.PopInt(),
        };
}
