using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Marketplace;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Marketplace;

internal class BuyMarketplaceTokensMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new BuyMarketplaceTokensMessage();
}
