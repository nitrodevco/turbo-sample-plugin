using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Rooms;
using Turbo.Primitives.Messages.Incoming.RoomSettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;

internal class UpdateRoomCategoryAndTradeSettingsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new UpdateRoomCategoryAndTradeSettingsMessage
        {
            RoomId = packet.PopInt(),
            CategoryId = packet.PopInt(),
            TradeType = (RoomTradeModeType)packet.PopInt(),
        };
}
