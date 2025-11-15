using Turbo.Primitives.Messages.Outgoing.Notifications;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class MOTDNotificationEventMessageComposerSerializer(int header)
    : AbstractSerializer<MOTDNotificationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MOTDNotificationEventMessageComposer message
    )
    {
        //
    }
}
