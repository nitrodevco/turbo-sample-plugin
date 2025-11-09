using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Crafting;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Crafting;

internal class CraftMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CraftMessage();
}
