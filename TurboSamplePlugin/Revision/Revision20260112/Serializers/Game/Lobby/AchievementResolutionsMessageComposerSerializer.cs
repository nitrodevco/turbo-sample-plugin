using Turbo.Primitives.Messages.Outgoing.Game.Lobby;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Game.Lobby;

internal class AchievementResolutionsMessageComposerSerializer(int header)
    : AbstractSerializer<AchievementResolutionsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AchievementResolutionsMessageComposer message
    )
    {
        //
    }
}
