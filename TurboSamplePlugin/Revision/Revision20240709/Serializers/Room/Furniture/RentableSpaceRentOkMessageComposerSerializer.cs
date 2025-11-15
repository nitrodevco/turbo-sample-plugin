using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class RentableSpaceRentOkMessageComposerSerializer(int header)
    : AbstractSerializer<RentableSpaceRentOkMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RentableSpaceRentOkMessageComposer message
    )
    {
        packet.WriteInteger(message.ExpiryTime);
    }
}
