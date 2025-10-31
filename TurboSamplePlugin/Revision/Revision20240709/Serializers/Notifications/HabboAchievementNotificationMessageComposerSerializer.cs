using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class HabboAchievementNotificationMessageComposerSerializer(int header)
    : AbstractSerializer<HabboAchievementNotificationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HabboAchievementNotificationMessageComposer message
    )
    {
        //
    }
}
