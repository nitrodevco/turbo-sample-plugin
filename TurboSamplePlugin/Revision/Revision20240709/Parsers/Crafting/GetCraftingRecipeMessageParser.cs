using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Crafting;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Crafting;

internal class GetCraftingRecipeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetCraftingRecipeMessage();
}
