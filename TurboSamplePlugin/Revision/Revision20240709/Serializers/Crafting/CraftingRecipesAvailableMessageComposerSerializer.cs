using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Crafting;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Crafting;

internal class CraftingRecipesAvailableMessageComposerSerializer(int header)
    : AbstractSerializer<CraftingRecipesAvailableMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CraftingRecipesAvailableMessageComposer message
    )
    {
        //
    }
}
