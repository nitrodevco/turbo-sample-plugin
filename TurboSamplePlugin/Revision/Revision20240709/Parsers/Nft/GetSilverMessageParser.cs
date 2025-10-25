using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Nft;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Nft;

public class GetSilverMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetSilverMessage();
}
