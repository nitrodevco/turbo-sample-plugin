using Turbo.Primitives.Messages.Incoming.Handshake;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Handshake;

internal class VersionCheckMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new VersionCheckMessage
        {
            ClientID = packet.PopInt(),
            ClientURL = packet.PopString(),
            ExternalVariablesURL = packet.PopString(),
        };
}
