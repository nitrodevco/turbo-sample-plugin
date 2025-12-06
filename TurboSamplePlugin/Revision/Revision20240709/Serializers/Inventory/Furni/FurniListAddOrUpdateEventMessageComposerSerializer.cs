using Turbo.Primitives.Messages.Outgoing.Inventory.Furni;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Furni.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Furni;

internal class FurniListAddOrUpdateEventMessageComposerSerializer(int header)
    : AbstractSerializer<FurniListAddOrUpdateEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FurniListAddOrUpdateEventMessageComposer message
    )
    {
        FurnitureItemSerializer.Serialize(packet, message.Item);
    }
}
