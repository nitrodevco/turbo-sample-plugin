using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class YoutubeDisplayVideoMessageComposerSerializer(int header)
    : AbstractSerializer<YoutubeDisplayVideoMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        YoutubeDisplayVideoMessageComposer message
    )
    {
        //
    }
}
