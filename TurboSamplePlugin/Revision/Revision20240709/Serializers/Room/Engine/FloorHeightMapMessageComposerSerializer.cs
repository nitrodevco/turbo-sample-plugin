using Turbo.Contracts.Enums.Rooms;
using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class FloorHeightMapMessageComposerSerializer(int header)
    : AbstractSerializer<FloorHeightMapMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FloorHeightMapMessageComposer message)
    {
        packet
            .WriteBoolean(message.ScaleType is RoomScaleType.Small)
            .WriteInteger(message.FixedWallsHeight)
            .WriteString(message.ModelData)
            .WriteInteger(message.AreaHideData.Count);

        foreach (var area in message.AreaHideData)
            AreaHideDataSerializer.Serialize(packet, area);
    }
}
