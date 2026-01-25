using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine;

internal class ItemAddMessageComposerSerializer(int header)
    : AbstractSerializer<ItemAddMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ItemAddMessageComposer message)
    {
        WallItemSerializer.Serialize(packet, message.WallItem);

        packet.WriteString(message.WallItem.OwnerName);
    }
}
