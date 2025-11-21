using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ObjectAddMessageComposerSerializer(int header)
    : AbstractSerializer<ObjectAddMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ObjectAddMessageComposer message)
    {
        FloorItemSerializer.Serialize(packet, message.FloorItem);

        packet.WriteString(message.OwnerName);
    }
}
