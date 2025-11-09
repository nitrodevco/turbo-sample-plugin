using Turbo.Contracts.Enums.Rooms.Furniture.Data;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Orleans.Snapshots.Rooms.StuffData;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class StuffDataSnapshotSerializer
{
    public static void Serialize(IServerPacket packet, StuffDataSnapshot item)
    {
        packet.WriteInteger(item.StuffBitmask);

        if (item.LegacyPayload is not null)
        {
            packet.WriteString(item.LegacyPayload.LegacyString);
        }
        else if (item.MapPayload is not null)
        {
            packet.WriteInteger(item.MapPayload.Data.Length);

            foreach (var (key, value) in item.MapPayload.Data)
                packet.WriteString(key).WriteString(value);
        }
        else if (item.NumberPayload is not null)
        {
            packet.WriteInteger(item.NumberPayload.Data.Length);

            foreach (var value in item.NumberPayload.Data)
                packet.WriteInteger(value);
        }
        else if (item.StringPayload is not null)
        {
            packet.WriteInteger(item.StringPayload.Data.Length);

            foreach (var value in item.StringPayload.Data)
                packet.WriteString(value);
        }

        if ((item.StuffBitmask & (int)StuffDataFlags.Unique) != 0)
            packet.WriteInteger(item.UniqueNumber).WriteInteger(item.UniqueSeries);
    }
}
