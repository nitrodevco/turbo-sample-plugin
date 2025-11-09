using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Marketplace;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Marketplace;

internal class GetMarketplaceOffersMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetMarketplaceOffersMessage();
}
