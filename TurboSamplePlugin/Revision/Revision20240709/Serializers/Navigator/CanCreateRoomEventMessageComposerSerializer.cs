using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class CanCreateRoomEventMessageComposerSerializer(int header)
    : AbstractSerializer<CanCreateRoomEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CanCreateRoomEventMessageComposer message
    )
    {
        packet.WriteBoolean(message.CanCreateEvent).WriteInteger(message.ErrorCode);
    }
}
