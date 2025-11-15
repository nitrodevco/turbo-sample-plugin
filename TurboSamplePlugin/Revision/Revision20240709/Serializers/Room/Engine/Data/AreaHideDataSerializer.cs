using Turbo.Packets.Abstractions;
using Turbo.Primitives.Orleans.Snapshots.Room.Furniture;
using Turbo.Primitives.Snapshots.Rooms.Mapping;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class AreaHideDataSerializer
{
    public static void Serialize(IServerPacket packet, AreaHideDataSnapshot areaHideData)
    {
        packet
            .WriteInteger(areaHideData.FurniId)
            .WriteBoolean(areaHideData.On)
            .WriteInteger(areaHideData.RootX)
            .WriteInteger(areaHideData.RootY)
            .WriteInteger(areaHideData.Width)
            .WriteInteger(areaHideData.Length)
            .WriteBoolean(areaHideData.Invert);
    }
}
