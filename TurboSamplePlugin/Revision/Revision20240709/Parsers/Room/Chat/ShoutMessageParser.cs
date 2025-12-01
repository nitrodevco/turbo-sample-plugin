using Turbo.Primitives.Messages.Incoming.Room.Chat;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Chat;

internal class ShoutMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ShoutMessage();
}
