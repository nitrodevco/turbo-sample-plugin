using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class RoomInfoUpdatedMessageComposerSerializer(int header)
    : AbstractSerializer<RoomInfoUpdatedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomInfoUpdatedMessageComposer message)
    {
        packet.WriteInteger(message.RoomId);
    }
}
