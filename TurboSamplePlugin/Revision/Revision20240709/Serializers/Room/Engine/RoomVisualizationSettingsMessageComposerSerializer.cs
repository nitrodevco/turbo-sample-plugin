using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class RoomVisualizationSettingsMessageComposerSerializer(int header)
    : AbstractSerializer<RoomVisualizationSettingsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomVisualizationSettingsMessageComposer message
    )
    {
        //
    }
}
