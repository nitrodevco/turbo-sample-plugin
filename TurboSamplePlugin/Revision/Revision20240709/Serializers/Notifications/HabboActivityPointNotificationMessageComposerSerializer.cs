using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class HabboActivityPointNotificationMessageComposerSerializer(int header)
    : AbstractSerializer<HabboActivityPointNotificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HabboActivityPointNotificationMessageComposer message
    )
    {
        //
    }
}
