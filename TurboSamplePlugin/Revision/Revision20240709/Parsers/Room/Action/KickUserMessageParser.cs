using Turbo.Primitives.Messages.Incoming.Room.Action;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Action;

internal class KickUserMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new KickUserMessage();
}
