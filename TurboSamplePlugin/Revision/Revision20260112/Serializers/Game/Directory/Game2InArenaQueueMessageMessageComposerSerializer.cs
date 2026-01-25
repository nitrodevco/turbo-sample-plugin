using Turbo.Primitives.Messages.Outgoing.Game.Directory;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Game.Directory;

internal class Game2InArenaQueueMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2InArenaQueueMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2InArenaQueueMessageMessageComposer message
    )
    {
        //
    }
}
