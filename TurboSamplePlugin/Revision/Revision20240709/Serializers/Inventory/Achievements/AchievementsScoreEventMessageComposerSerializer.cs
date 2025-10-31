using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Achievements;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Achievements;

internal class AchievementsScoreEventMessageComposerSerializer(int header)
    : AbstractSerializer<AchievementsScoreEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AchievementsScoreEventMessageComposer message
    )
    {
        //
    }
}
