using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class RespectNotificationMessageComposerSerializer(int header)
    : AbstractSerializer<RespectNotificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RespectNotificationMessageComposer message
    )
    {
        //
    }
}
