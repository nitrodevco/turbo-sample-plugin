using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Enums;
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
            .WriteString(item.Z.ToString())
            .WriteInteger((int)item.BodyRotation);

        if (item is RoomPlayerAvatarSnapshot player)
        {
            packet
                .WriteInteger((int)RoomObjectType.Player)
                .WriteString(AvatarGenderTypeExtensions.ToLegacyString(player.Gender))
                .WriteInteger(player.GroupId)
                .WriteInteger(player.GroupStatus)
                .WriteString(player.GroupName)
                .WriteString(player.SwimFigure)
                .WriteInteger(player.ActivityPoints)
                .WriteBoolean(player.IsModerator);
        }
    }
}
