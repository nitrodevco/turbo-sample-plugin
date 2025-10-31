using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Score;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Score;

internal class Game2GroupLeaderboardMessageComposerSerializer(int header)
    : AbstractSerializer<Game2GroupLeaderboardMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2GroupLeaderboardMessageComposer message
    )
    {
        //
    }
}
