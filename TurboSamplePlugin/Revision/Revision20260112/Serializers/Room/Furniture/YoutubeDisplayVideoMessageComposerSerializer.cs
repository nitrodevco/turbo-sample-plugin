using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Furniture;

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
