using Turbo.Primitives.Messages.Outgoing.Room.Session;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Session;

internal class RoomForwardMessageComposerSerializer(int header)
    : AbstractSerializer<RoomForwardMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomForwardMessageComposer message)
    {
        packet.WriteInteger(message.RoomId);
    }
}
