using Turbo.Primitives.Messages.Outgoing.Room.Session;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Session;

internal class YouArePlayingGameMessageComposerSerializer(int header)
    : AbstractSerializer<YouArePlayingGameMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        YouArePlayingGameMessageComposer message
    )
    {
        packet.WriteBoolean(message.IsPlaying);
    }
}
