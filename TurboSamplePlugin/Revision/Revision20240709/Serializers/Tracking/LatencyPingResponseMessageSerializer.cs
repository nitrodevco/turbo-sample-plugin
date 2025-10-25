using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Tracking;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Tracking;

internal class LatencyPingResponseMessageSerializer(int header)
    : AbstractSerializer<LatencyPingResponseMessage>(header)
{
    protected override void Serialize(IServerPacket packet, LatencyPingResponseMessage message)
    {
        packet.WriteInteger(message.RequestId);
    }
}
