using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Bots;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Bots;

internal class GetBotInventoryMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetBotInventoryMessage();
}
