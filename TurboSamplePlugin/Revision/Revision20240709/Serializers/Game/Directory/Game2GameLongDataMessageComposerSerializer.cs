using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2GameLongDataMessageComposerSerializer(int header)
    : AbstractSerializer<Game2GameLongDataMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2GameLongDataMessageComposer message
    )
    {
        //
    }
}
