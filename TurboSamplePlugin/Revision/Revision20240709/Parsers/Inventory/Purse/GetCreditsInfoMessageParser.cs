using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Purse;

internal class GetCreditsInfoMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetCreditsInfoMessage();
}
