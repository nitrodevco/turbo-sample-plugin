using Turbo.Primitives.Messages.Incoming.Moderator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Moderator;

internal class ModKickMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ModKickMessage();
}
