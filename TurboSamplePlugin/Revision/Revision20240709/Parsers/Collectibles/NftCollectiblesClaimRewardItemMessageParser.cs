using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Collectibles;

internal class NftCollectiblesClaimRewardItemMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new NftCollectiblesClaimRewardItemMessage();
}
