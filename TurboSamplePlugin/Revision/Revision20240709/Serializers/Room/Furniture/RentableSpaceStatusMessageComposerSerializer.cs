using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class RentableSpaceStatusMessageComposerSerializer(int header)
    : AbstractSerializer<RentableSpaceStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RentableSpaceStatusMessageComposer message
    )
    {
        packet
            .WriteBoolean(message.Rented)
            .WriteInteger((int)message.CanRentErrorCode)
            .WriteInteger(message.RenterId)
            .WriteString(message.RenterName)
            .WriteInteger(message.TimeRemaining)
            .WriteInteger(message.Price);
    }
}
