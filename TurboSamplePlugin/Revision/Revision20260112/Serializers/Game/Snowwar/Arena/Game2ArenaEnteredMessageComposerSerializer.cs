using Turbo.Primitives.Messages.Outgoing.Game.Snowwar.Arena;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Game.Snowwar.Arena;

internal class Game2ArenaEnteredMessageComposerSerializer(int header)
    : AbstractSerializer<Game2ArenaEnteredMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2ArenaEnteredMessageComposer message
    )
    {
        //
    }
}
