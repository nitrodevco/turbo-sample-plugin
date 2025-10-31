using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Camera;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;

internal class CameraPublishStatusMessageComposerSerializer(int header)
    : AbstractSerializer<CameraPublishStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CameraPublishStatusMessageComposer message
    )
    {
        //
    }
}
