using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Trading;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Trading;

internal class RemoveItemFromTradeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RemoveItemFromTradeMessage();
}
