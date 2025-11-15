using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Nft;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Nft;

internal class SaveUserNftWardrobeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SaveUserNftWardrobeMessage();
}
