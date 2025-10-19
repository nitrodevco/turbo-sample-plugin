using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Tracking;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;

public class LatencyPingReportParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new LatencyPingReportMessage
        {
            AverageLatency = packet.PopInt(),
            ValidPingAverage = packet.PopInt(),
            NumPings = packet.PopInt(),
        };
}
