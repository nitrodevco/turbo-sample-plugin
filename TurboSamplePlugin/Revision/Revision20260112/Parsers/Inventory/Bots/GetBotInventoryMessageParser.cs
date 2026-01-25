using Turbo.Primitives.Messages.Incoming.Inventory.Bots;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Inventory.Bots;

internal class GetBotInventoryMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetBotInventoryMessage();
}
