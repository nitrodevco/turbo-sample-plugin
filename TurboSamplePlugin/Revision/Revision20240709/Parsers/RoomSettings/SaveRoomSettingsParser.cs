using System.Collections.Generic;
using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Navigator;
using Turbo.Contracts.Enums.Navigator.Chat;
using Turbo.Contracts.Enums.Rooms;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.RoomSettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;

public class SaveRoomSettingsParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new SaveRoomSettingsMessage
        {
            RoomId = packet.PopInt(),
            RoomName = packet.PopString(),
            RoomDescription = packet.PopString(),
            DoorMode = packet.PopInt(),
            Password = packet.PopString(),
            MaxVisitors = packet.PopInt(),
            CategoryId = packet.PopInt(),
            Tags = ParseTags(packet),
            TradeMode = (TradeModeType)packet.PopInt(),
            AllowPets = packet.PopBoolean(),
            AllowFoodConsume = packet.PopBoolean(),
            AllowWalkThrough = packet.PopBoolean(),
            HideWalls = packet.PopBoolean(),
            WallThickness = (RoomThicknessType)packet.PopInt(),
            FloorThickness = (RoomThicknessType)packet.PopInt(),
            WhoCanMute = (ModSettingType)packet.PopInt(),
            WhoCanKick = (ModSettingType)packet.PopInt(),
            WhoCanBan = (ModSettingType)packet.PopInt(),
            ChatMode = (ChatModeType)packet.PopInt(),
            ChatBubbleSize = (ChatBubbleWidthType)packet.PopInt(),
            ChatScrollUpFrequency = (ChatScrollSpeedType)packet.PopInt(),
            ChatFullHearRange = packet.PopInt(),
            ChatFloodSensitivity = (ChatFloodSensitivityType)packet.PopInt(),
            AllowNavigatorDynCats = packet.PopBoolean(),
        };

    private static List<string> ParseTags(IClientPacket packet)
    {
        var tagCount = packet.PopInt();
        var tags = new List<string>();

        for (var i = 0; i < tagCount; i++)
            tags.Add(packet.PopString());

        return tags;
    }
}
