using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Collectibles;

internal class NftTransferAssetsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new NftTransferAssetsMessage();
}
