using Turbo.Primitives.Messages.Incoming.Users;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;

internal class GetMOTDMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetMOTDMessage();
}
