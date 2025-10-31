using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2GameDirectoryStatusMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2GameDirectoryStatusMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2GameDirectoryStatusMessageMessageComposer message
    )
    {
        //
    }
}
