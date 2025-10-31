using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2JoiningGameFailedMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2JoiningGameFailedMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2JoiningGameFailedMessageMessageComposer message
    )
    {
        //
    }
}
