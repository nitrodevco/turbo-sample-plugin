using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

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
