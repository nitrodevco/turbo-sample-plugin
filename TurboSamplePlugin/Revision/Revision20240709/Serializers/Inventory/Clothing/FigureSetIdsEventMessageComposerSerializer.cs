using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Clothing;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Clothing;

internal class FigureSetIdsEventMessageComposerSerializer(int header)
    : AbstractSerializer<FigureSetIdsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FigureSetIdsEventMessageComposer message
    )
    {
        //
    }
}
