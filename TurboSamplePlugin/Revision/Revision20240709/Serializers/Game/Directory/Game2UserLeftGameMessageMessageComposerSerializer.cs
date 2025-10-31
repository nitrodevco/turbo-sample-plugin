using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Game.Directory;

internal class Game2UserLeftGameMessageMessageComposerSerializer(int header)
    : AbstractSerializer<Game2UserLeftGameMessageMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        Game2UserLeftGameMessageMessageComposer message
    )
    {
        //
    }
}
