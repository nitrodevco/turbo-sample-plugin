using System.Collections.Generic;
using Turbo.Contracts.Enums.Navigator;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Orleans.Snapshots.Room;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

internal class RoomSettingsSerializer
{
    public static void Serialize(IServerPacket packet, RoomSnapshot message)
    {
        var ownerName = string.Empty; // TODO: Fetch owner name by ownerId
        var userCount = 0; // TODO: Fetch current user count in the room
        var score = 0; // TODO: Fetch room score
        var ranking = 0; // TODO: Fetch room ranking
        var tags = new List<string>(); // TODO: Fetch room tags

        packet
            .WriteInteger((int)message.Id)
            .WriteString(message.Name)
            .WriteInteger(message.OwnerId)
            .WriteString(ownerName)
            .WriteInteger((int)message.DoorMode)
            .WriteInteger(userCount)
            .WriteInteger(message.PlayersMax)
            .WriteString(message.Description)
            .WriteInteger((int)message.TradeMode)
            .WriteInteger(score)
            .WriteInteger(ranking)
            .WriteInteger(message.CategoryId ?? -1)
            .WriteInteger(tags.Count);

        foreach (var tag in tags)
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
