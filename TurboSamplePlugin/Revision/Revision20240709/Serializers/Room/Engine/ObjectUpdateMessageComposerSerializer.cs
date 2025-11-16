using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ObjectUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<ObjectUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ObjectUpdateMessageComposer message)
    {
        FloorItemSerializer.Serialize(packet, message.FloorItem);
    }
}
