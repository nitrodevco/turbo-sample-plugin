using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Navigator;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

public class CreateFlatParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new CreateFlatMessage
        {
            FlatName = packet.PopString(),
            FlatDescription = packet.PopString(),
            FlatModelName = packet.PopString(),
            CategoryID = packet.PopInt(),
            MaxPlayers = packet.PopInt(),
            TradeSetting = (TradeModeType)packet.PopInt(),
        };
}
