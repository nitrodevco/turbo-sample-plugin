using Turbo.Primitives.Messages.Incoming.Handshake;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;

internal class SSOTicketMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new SSOTicketMessage { SSO = packet.PopString(), ElapsedMilliseconds = packet.PopInt() };
}
