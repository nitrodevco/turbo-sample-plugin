using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Snowwar.Ingame;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Snowwar.Ingame;

internal class Game2FullGameStatusMessageComposerSerializer(int header)
    : AbstractSerializer<Game2FullGameStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2FullGameStatusMessageComposer message
    )
    {
        //
    }
}
