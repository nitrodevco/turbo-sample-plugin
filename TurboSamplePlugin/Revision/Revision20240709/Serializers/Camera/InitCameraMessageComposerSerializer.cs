using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Camera;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;

internal class InitCameraMessageComposerSerializer(int header)
    : AbstractSerializer<InitCameraMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InitCameraMessageComposer message)
    {
        //
    }
}
