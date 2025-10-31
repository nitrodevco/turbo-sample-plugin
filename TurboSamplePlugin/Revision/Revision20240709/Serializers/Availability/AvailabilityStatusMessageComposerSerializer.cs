using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Availability;

internal class AvailabilityStatusMessageComposerSerializer(int header)
    : AbstractSerializer<AvailabilityStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AvailabilityStatusMessageComposer message
    )
    {
        packet
            .WriteBoolean(message.IsOpen)
            .WriteBoolean(message.OnShutDown)
            .WriteBoolean(message.IsAuthenticHabbo);
    }
}
