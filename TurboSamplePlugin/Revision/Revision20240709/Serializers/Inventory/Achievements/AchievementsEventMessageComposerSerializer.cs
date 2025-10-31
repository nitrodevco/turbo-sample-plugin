using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Achievements;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Achievements;

internal class AchievementsEventMessageComposerSerializer(int header)
    : AbstractSerializer<AchievementsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AchievementsEventMessageComposer message
    )
    {
        //
    }
}
