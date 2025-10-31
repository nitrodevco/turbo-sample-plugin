using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2StartCounterMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2StartCounterMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2StartCounterMessageMessageComposer message
    )
    {
        //
    }
}
