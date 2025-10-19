using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializer.Availability;

public class AvailabilityStatusMessageSerializer(int header)
    : AbstractSerializer<AvailabilityStatusMessage>(header)
{
    protected override void Serialize(IServerPacket packet, AvailabilityStatusMessage message)
    {
        packet
            .WriteBoolean(message.IsOpen)
            .WriteBoolean(message.OnShutDown)
            .WriteBoolean(message.IsAuthenticHabbo);
    }
}
