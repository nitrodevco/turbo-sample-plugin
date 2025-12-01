using Turbo.Primitives.Messages.Incoming.Tracking;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;

internal class LatencyPingRequestMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new LatencyPingRequestMessage { RequestId = packet.PopInt() };
}
