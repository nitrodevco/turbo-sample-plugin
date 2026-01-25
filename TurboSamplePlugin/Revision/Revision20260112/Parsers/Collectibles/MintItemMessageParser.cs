using Turbo.Primitives.Messages.Incoming.Collectibles;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Collectibles;

internal class MintItemMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new MintItemMessage();
}
