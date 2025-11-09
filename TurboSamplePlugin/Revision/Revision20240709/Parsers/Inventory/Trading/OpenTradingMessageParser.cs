using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Trading;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Trading;

internal class OpenTradingMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new OpenTradingMessage();
}
