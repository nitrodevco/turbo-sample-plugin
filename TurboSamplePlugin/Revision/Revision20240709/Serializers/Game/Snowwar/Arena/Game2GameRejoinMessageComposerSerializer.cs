using Turbo.Primitives.Messages.Outgoing.Game.Snowwar.Arena;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Snowwar.Arena;

internal class Game2GameRejoinMessageComposerSerializer(int header)
    : AbstractSerializer<Game2GameRejoinMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, Game2GameRejoinMessageComposer message)
    {
        //
    }
}
