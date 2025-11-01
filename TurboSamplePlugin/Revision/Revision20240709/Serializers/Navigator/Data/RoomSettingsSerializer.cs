using Turbo.Contracts.Enums.Navigator;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

internal class RoomSettingsSerializer
{
    public static void Serialize(IServerPacket packet, RoomSettingsSnapshot message)
    {
        packet
            .WriteInteger(message.RoomId)
            .WriteString(message.Name)
            .WriteInteger(message.OwnerId)
            .WriteString(message.OwnerName)
            .WriteInteger((int)message.DoorMode)
            .WriteInteger(message.UserCount)
            .WriteInteger(message.MaxUserCount)
            .WriteString(message.Description)
            .WriteInteger((int)message.TradeMode)
            .WriteInteger(message.Score)
            .WriteInteger(message.Ranking)
            .WriteInteger(message.CategoryId)
            .WriteInteger(message.Tags.Count);

        foreach (var tag in message.Tags)
            packet.WriteString(tag);

        packet.WriteInteger((int)message.Bitmask);

        if (message.Bitmask.HasFlag(RoomBitmask.Thumbnail))
        {
            packet.WriteString(string.Empty); // officialRoomPicRef
        }

        if (message.Bitmask.HasFlag(RoomBitmask.GroupData))
        {
            packet
                .WriteInteger(0) // groupId
                .WriteString(string.Empty) // groupName
                .WriteString(string.Empty); // groupBadgeCode
        }

        if (message.Bitmask.HasFlag(RoomBitmask.RoomAd))
        {
            packet
                .WriteString(string.Empty) // adName
                .WriteString(string.Empty) // adDescription
                .WriteInteger(0); // roomAdExpiresInMin
        }
    }
}
