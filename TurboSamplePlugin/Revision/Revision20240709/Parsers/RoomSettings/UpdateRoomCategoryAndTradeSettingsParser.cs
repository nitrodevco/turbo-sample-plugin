using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Rooms;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.RoomSettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;

public class UpdateRoomCategoryAndTradeSettingsParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new UpdateRoomCategoryAndTradeSettingsMessage
        {
            RoomId = packet.PopInt(),
            CategoryId = packet.PopInt(),
            TradeType = (RoomTradeType)packet.PopInt(),
        };
}
