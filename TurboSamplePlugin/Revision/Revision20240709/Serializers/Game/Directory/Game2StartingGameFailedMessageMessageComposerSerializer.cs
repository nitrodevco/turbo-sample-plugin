using Turbo.Primitives.Messages.Outgoing.Game.Directory;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2StartingGameFailedMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2StartingGameFailedMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2StartingGameFailedMessageMessageComposer message
    )
    {
        //
    }
}
