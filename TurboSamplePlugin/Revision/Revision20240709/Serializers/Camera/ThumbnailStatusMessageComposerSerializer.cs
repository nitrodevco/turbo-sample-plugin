using Turbo.Primitives.Messages.Outgoing.Camera;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;

internal class ThumbnailStatusMessageComposerSerializer(int header)
    : AbstractSerializer<ThumbnailStatusMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ThumbnailStatusMessageComposer message)
    {
        //
    }
}
