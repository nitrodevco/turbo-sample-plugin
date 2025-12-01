using Turbo.Primitives.Messages.Incoming.Marketplace;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Marketplace;

internal class GetMarketplaceCanMakeOfferMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetMarketplaceCanMakeOfferMessage();
}
