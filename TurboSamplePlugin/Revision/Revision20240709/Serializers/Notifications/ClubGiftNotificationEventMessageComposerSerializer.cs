using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class ClubGiftNotificationEventMessageComposerSerializer(int header)
    : AbstractSerializer<ClubGiftNotificationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ClubGiftNotificationEventMessageComposer message
    )
    {
        //
    }
}
