using Turbo.Primitives.Messages.Outgoing.Inventory.Furni;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Furni;

internal class FurniListRemoveEventMessageComposerSerializer(int header)
    : AbstractSerializer<FurniListRemoveEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FurniListRemoveEventMessageComposer message
    )
    {
        //
    }
}
