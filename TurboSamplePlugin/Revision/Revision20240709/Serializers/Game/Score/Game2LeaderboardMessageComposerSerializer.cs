using Turbo.Primitives.Messages.Outgoing.Game.Score;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Score;

internal class Game2LeaderboardMessageComposerSerializer(int header)
    : AbstractSerializer<Game2LeaderboardMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, Game2LeaderboardMessageComposer message)
    {
        //
    }
}
