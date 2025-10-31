using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Session;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class YouArePlayingGameMessageComposerSerializer(int header)
    : AbstractSerializer<YouArePlayingGameMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        YouArePlayingGameMessageComposer message
    )
    {
        //
    }
}
