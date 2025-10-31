using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

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
