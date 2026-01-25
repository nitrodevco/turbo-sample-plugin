using Turbo.Primitives.Messages.Outgoing.Camera;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Camera;

internal class InitCameraMessageComposerSerializer(int header)
    : AbstractSerializer<InitCameraMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InitCameraMessageComposer message)
    {
        //
    }
}
