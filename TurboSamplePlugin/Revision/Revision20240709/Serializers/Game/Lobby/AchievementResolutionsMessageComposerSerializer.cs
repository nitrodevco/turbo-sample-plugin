using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Lobby;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Lobby;

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
