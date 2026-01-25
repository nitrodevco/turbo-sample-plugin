using Turbo.Primitives.Messages.Incoming.Room.Avatar;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Room.Avatar;

internal class DropCarryItemMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new DropCarryItemMessage();
}
