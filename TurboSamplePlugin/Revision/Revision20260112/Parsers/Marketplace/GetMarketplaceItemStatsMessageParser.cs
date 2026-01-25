using Turbo.Primitives.Messages.Incoming.Marketplace;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Marketplace;

internal class GetMarketplaceItemStatsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetMarketplaceItemStatsMessage();
}
