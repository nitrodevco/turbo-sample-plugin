using Turbo.Contracts.Enums.Navigator;
using Turbo.Primitives.Orleans.Snapshots.Room;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

internal class RoomSettingsSerializer
{
    public static void Serialize(IServerPacket packet, RoomInfoSnapshot message)
    {
        packet
            .WriteInteger((int)message.RoomId)
            .WriteString(message.RoomName)
            .WriteInteger((int)message.OwnerId)
            .WriteString(message.OwnerName)
            .WriteInteger((int)message.DoorMode)
            .WriteInteger(message.UserCount)
            .WriteInteger(message.PlayersMax)
            .WriteString(message.Description)
            .WriteInteger((int)message.TradeMode)
            .WriteInteger(message.Score)
            .WriteInteger(message.Ranking)
            .WriteInteger(message.CategoryId ?? -1)
            .WriteInteger(message.Tags.Length);

        foreach (var tag in message.Tags)
            packet.WriteString(tag);

        var bitmask = RoomBitmask.None;

        bitmask |= RoomBitmask.ShowOwner;

        packet.WriteInteger((int)bitmask);

        if (bitmask.HasFlag(RoomBitmask.Thumbnail))
        {
            packet.WriteString(string.Empty); // officialRoomPicRef
        }

        if (bitmask.HasFlag(RoomBitmask.GroupData))
        {
            packet
                .WriteInteger(0) // groupId
                .WriteString(string.Empty) // groupName
                .WriteString(string.Empty); // groupBadgeCode
        }

        if (bitmask.HasFlag(RoomBitmask.RoomAd))
        {
            packet
                .WriteString(string.Empty) // adName
                .WriteString(string.Empty) // adDescription
                .WriteInteger(0); // roomAdExpiresInMin
        }
    }
}
