using Turbo.Primitives.Messages.Incoming.Crafting;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Crafting;

internal class CraftMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CraftMessage();
}
