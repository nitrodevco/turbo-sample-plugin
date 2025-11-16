using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Rooms;
using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class CreateFlatMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new CreateFlatMessage
        {
            FlatName = packet.PopString(),
            FlatDescription = packet.PopString(),
            FlatModelName = packet.PopString(),
            CategoryID = packet.PopInt(),
            MaxPlayers = packet.PopInt(),
            TradeSetting = (RoomTradeModeType)packet.PopInt(),
        };
}
