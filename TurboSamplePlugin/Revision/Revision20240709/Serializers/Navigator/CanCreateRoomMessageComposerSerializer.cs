using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class CanCreateRoomMessageComposerSerializer(int header)
    : AbstractSerializer<CanCreateRoomMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CanCreateRoomMessageComposer message)
    {
        packet.WriteInteger(message.ResultCode).WriteInteger(message.RoomLimit);
    }
}
