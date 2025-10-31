using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Crafting;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Crafting;

internal class CraftableProductsMessageComposerSerializer(int header)
    : AbstractSerializer<CraftableProductsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CraftableProductsMessageComposer message
    )
    {
        //
    }
}
