using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class CustomStackingHeightUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<CustomStackingHeightUpdateMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CustomStackingHeightUpdateMessageComposer message
    )
    {
        packet.WriteInteger(message.FurniId).WriteInteger(message.Height);
    }
}
