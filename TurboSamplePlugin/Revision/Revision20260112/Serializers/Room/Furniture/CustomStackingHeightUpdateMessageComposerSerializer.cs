using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Furniture;

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
