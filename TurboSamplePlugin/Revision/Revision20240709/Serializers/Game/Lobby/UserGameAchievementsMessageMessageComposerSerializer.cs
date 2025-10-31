using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Lobby;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Lobby;

internal class UserGameAchievementsMessageMessageComposerSerializer(int header)
    : AbstractSerializer<UserGameAchievementsMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        UserGameAchievementsMessageMessageComposer message
    )
    {
        //
    }
}
