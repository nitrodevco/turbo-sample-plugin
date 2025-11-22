using Turbo.Contracts.Enums.Furniture;
using Turbo.Primitives.Orleans.Snapshots.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class WallItemSerializer
{
    public static void Serialize(IServerPacket packet, RoomWallItemSnapshot item)
    {
        packet
            .WriteString(item.Id.ToString())
            .WriteInteger(item.SpriteId)
            .WriteString(item.WallLocation);

        StuffDataSnapshotSerializer.SerializeLegacyString(packet, item.StuffData);

        packet
            .WriteInteger(-1) // expiration
            .WriteInteger((int)item.UsagePolicy)
            .WriteInteger((int)item.OwnerId);
    }
}
