using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class CustomUserNotificationMessageComposerSerializer(int header)
    : AbstractSerializer<CustomUserNotificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CustomUserNotificationMessageComposer message
    )
    {
        packet.WriteInteger((int)message.Code);
    }
}
