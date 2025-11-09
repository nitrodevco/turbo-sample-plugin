using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Tracking;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;

internal class LatencyPingRequestMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new LatencyPingRequestMessage { RequestId = packet.PopInt() };
}
