using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Crafting;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Crafting;

internal class CraftingResultMessageComposerSerializer(int header)
    : AbstractSerializer<CraftingResultMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CraftingResultMessageComposer message)
    {
        //
    }
}
