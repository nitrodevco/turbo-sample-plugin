using Turbo.Primitives.Messages.Incoming.Inventory;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Inventory.Purse;

internal class GetCreditsInfoMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetCreditsInfoMessage();
}
