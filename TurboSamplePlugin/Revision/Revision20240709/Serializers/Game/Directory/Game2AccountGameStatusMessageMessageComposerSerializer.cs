using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2AccountGameStatusMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2AccountGameStatusMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2AccountGameStatusMessageMessageComposer message
    )
    {
        //
    }
}
