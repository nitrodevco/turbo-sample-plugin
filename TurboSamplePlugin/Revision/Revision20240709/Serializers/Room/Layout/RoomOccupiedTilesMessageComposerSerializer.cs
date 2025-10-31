using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Layout;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Layout;

internal class RoomOccupiedTilesMessageComposerSerializer(int header)
    : AbstractSerializer<RoomOccupiedTilesMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomOccupiedTilesMessageComposer message
    )
    {
        //
    }
}
