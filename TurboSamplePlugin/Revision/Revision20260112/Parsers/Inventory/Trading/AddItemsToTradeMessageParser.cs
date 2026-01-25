using Turbo.Primitives.Messages.Incoming.Inventory.Trading;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Inventory.Trading;

internal class AddItemsToTradeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new AddItemsToTradeMessage();
}
