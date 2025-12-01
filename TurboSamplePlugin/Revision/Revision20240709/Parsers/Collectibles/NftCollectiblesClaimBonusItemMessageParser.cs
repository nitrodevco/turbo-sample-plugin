using Turbo.Primitives.Messages.Incoming.Collectibles;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Collectibles;

internal class NftCollectiblesClaimBonusItemMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new NftCollectiblesClaimBonusItemMessage();
}
