using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ObjectsMessageComposerSerializer(int header)
    : AbstractSerializer<ObjectsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ObjectsMessageComposer message)
    {
        packet.WriteInteger(message.OwnerNames.Count);

        foreach (var (ownerId, ownerName) in message.OwnerNames)
        {
            packet.WriteInteger((int)ownerId);
            packet.WriteString(ownerName);
        }

        packet.WriteInteger(message.FloorItems.Length);

        foreach (var item in message.FloorItems)
        {
            FloorItemSerializer.Serialize(packet, item);
        }
    }
}
