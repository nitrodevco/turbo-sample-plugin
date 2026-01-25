using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine;

internal class ItemUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<ItemUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ItemUpdateMessageComposer message)
    {
        WallItemSerializer.Serialize(packet, message.WallItem);
    }
}
