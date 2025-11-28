using Turbo.Primitives.Messages.Outgoing.Room.Session;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class OpenConnectionMessageComposerSerializer(int header)
    : AbstractSerializer<OpenConnectionMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OpenConnectionMessageComposer message)
    {
        packet.WriteInteger((int)message.RoomId.Value);
    }
}
