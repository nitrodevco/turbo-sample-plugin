using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;

internal class PongMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new PongMessage();
}
