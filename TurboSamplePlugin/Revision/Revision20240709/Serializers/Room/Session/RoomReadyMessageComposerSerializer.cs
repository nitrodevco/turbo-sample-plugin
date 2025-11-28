using Turbo.Primitives.Messages.Outgoing.Room.Session;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class RoomReadyMessageComposerSerializer(int header)
    : AbstractSerializer<RoomReadyMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomReadyMessageComposer message)
    {
        packet.WriteString(message.WorldType).WriteInteger((int)message.RoomId.Value);
    }
}
