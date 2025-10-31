using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Crafting;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Crafting;

internal class CraftingRecipeMessageComposerSerializer(int header)
    : AbstractSerializer<CraftingRecipeMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CraftingRecipeMessageComposer message)
    {
        //
    }
}
