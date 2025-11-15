using Turbo.Primitives.Messages.Outgoing.Inventory.Clothing;
using Turbo.Primitives.Packets;

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
