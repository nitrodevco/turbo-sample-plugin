using Turbo.Primitives.Messages.Incoming.Room.Avatar;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Avatar;

internal class DanceMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new DanceMessage();
}
