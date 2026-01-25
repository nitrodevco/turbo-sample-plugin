using Turbo.Primitives.Messages.Outgoing.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Users;

internal class PetRespectNotificationEventMessageComposerSerializer(int header)
    : AbstractSerializer<PetRespectNotificationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PetRespectNotificationEventMessageComposer message
    )
    {
        //
    }
}
