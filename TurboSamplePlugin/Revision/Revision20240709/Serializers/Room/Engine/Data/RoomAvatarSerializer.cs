using Turbo.Contracts.Enums.Rooms.Object;
using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Object;
using Turbo.Primitives.Rooms.Snapshots.Avatars;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class RoomAvatarSerializer
{
    public static void Serialize(IServerPacket packet, RoomAvatarSnapshot item)
    {
        packet
            .WriteInteger((int)item.WebId)
            .WriteString(item.Name)
            .WriteString(item.Motto)
            .WriteString(item.Figure)
            .WriteInteger(item.ObjectId.Value)
            .WriteInteger(item.X)
            .WriteInteger(item.Y)
            .WriteString(string.Format("{0:N3}", item.Z))
            .WriteInteger((int)item.Rotation);

        if (item is RoomPlayerAvatarSnapshot player)
        {
            packet
                .WriteInteger((int)RoomObjectType.Player)
                .WriteString(AvatarGenderEnumExtensions.ToLegacyString(player.Gender))
                .WriteInteger(player.GroupId)
                .WriteInteger(player.GroupStatus)
                .WriteString(player.GroupName)
                .WriteString(player.SwimFigure)
                .WriteInteger(player.ActivityPoints)
                .WriteBoolean(player.IsModerator);
        }
    }
}
