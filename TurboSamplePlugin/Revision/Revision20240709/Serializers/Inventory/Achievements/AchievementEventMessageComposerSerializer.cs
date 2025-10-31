using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Achievements;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Achievements;

internal class AchievementEventMessageComposerSerializer(int header)
    : AbstractSerializer<AchievementEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, AchievementEventMessageComposer message)
    {
        //
    }
}
