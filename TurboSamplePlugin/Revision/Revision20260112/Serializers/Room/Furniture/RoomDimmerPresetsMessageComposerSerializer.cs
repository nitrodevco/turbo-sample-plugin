using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Furniture;

internal class RoomDimmerPresetsMessageComposerSerializer(int header)
    : AbstractSerializer<RoomDimmerPresetsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomDimmerPresetsMessageComposer message
    )
    {
        //
    }
}
