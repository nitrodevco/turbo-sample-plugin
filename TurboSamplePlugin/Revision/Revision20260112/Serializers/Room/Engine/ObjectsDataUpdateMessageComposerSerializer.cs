using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Engine;

internal class ObjectsDataUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<ObjectsDataUpdateMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ObjectsDataUpdateMessageComposer message
    )
    {
        packet.WriteInteger(message.StuffDatas.Count);

        foreach (var (itemId, stuffData) in message.StuffDatas)
        {
            packet.WriteInteger((int)itemId);

            StuffDataSnapshotSerializer.Serialize(packet, stuffData);
        }
    }
}
