using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Snapshots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class WallItemSerializer
{
    public static void Serialize(IServerPacket packet, RoomWallItemSnapshot item)
    {
        packet
            .WriteString(item.Id.ToString())
            .WriteInteger(item.SpriteId)
            .WriteString(item.WallLocation)
            .WriteString(item.StuffData)
            .WriteInteger(-1) // expiration
            .WriteInteger((int)item.UsagePolicy)
            .WriteInteger((int)item.OwnerId);
    }
}
