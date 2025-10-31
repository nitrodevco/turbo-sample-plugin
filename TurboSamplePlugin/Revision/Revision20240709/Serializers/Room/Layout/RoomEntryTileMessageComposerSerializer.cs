using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Layout;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Layout;

internal class RoomEntryTileMessageComposerSerializer(int header)
    : AbstractSerializer<RoomEntryTileMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomEntryTileMessageComposer message)
    {
        //
    }
}
