using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class RoomMessageNotificationMessageComposerSerializer(int header)
    : AbstractSerializer<RoomMessageNotificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomMessageNotificationMessageComposer message
    )
    {
        //
    }
}
