using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Furni;

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
