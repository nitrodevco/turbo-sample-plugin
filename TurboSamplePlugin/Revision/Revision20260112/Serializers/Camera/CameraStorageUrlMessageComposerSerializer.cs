using Turbo.Primitives.Messages.Outgoing.Camera;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Camera;

internal class CameraStorageUrlMessageComposerSerializer(int header)
    : AbstractSerializer<CameraStorageUrlMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CameraStorageUrlMessageComposer message)
    {
        //
    }
}
