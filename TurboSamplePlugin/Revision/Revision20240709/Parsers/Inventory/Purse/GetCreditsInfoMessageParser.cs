using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Purse;

internal class GetCreditsInfoMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetCreditsInfoMessage();
}
