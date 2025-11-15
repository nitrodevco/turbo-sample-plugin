using Turbo.Primitives.Messages.Outgoing.Notifications;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class PetLevelNotificationEventMessageComposerSerializer(int header)
    : AbstractSerializer<PetLevelNotificationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PetLevelNotificationEventMessageComposer message
    )
    {
        //
    }
}
