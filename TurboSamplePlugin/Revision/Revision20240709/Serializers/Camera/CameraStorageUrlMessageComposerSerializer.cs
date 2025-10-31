using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Camera;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;

internal class CameraStorageUrlMessageComposerSerializer(int header)
    : AbstractSerializer<CameraStorageUrlMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CameraStorageUrlMessageComposer message)
    {
        //
    }
}
