using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Snowwar.Arena;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Snowwar.Arena;

internal class Game2GameEndingMessageComposerSerializer(int header)
    : AbstractSerializer<Game2GameEndingMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, Game2GameEndingMessageComposer message)
    {
        //
    }
}
