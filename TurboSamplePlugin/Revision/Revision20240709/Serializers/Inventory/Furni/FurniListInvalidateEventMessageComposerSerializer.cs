using Turbo.Primitives.Messages.Outgoing.Inventory.Furni;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Furni;

internal class FurniListInvalidateEventMessageComposerSerializer(int header)
    : AbstractSerializer<FurniListInvalidateEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FurniListInvalidateEventMessageComposer message
    )
    {
        //
    }
}
