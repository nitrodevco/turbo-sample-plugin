using Turbo.Contracts.Enums.Furniture;
using Turbo.Primitives.Orleans.Snapshots.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class FloorItemSerializer
{
    public static void Serialize(IServerPacket packet, RoomFloorItemSnapshot item)
    {
        packet
            .WriteInteger((int)item.Id)
            .WriteInteger(item.SpriteId)
            .WriteInteger(item.X)
            .WriteInteger(item.Y)
            .WriteInteger((int)item.Rotation)
            .WriteString(string.Format("{0:N3}", item.Z))
            .WriteString(string.Format("{0:N3}", item.StackHeight))
            .WriteInteger(0); // extra

        StuffDataSnapshotSerializer.Serialize(packet, item.StuffData);

        packet
            .WriteInteger(-1) // expiration
            .WriteInteger((int)item.UsagePolicy)
            .WriteInteger((int)item.OwnerId);

        // if no sprite id, WriteString(staticClass)
    }
}
