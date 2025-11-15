using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Handshake;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;

internal class DisconnectMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new DisconnectMessage();
}
