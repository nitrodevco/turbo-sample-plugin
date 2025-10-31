using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Session;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class RoomQueueStatusMessageComposerSerializer(int header)
    : AbstractSerializer<RoomQueueStatusMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomQueueStatusMessageComposer message)
    {
        //
    }
}
