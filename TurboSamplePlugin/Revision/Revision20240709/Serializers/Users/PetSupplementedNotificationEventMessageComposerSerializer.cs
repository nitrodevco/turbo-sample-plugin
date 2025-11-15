using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class PetSupplementedNotificationEventMessageComposerSerializer(int header)
    : AbstractSerializer<PetSupplementedNotificationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PetSupplementedNotificationEventMessageComposer message
    )
    {
        //
    }
}
