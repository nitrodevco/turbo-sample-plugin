using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Camera;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;

internal class CameraPurchaseOKMessageComposerSerializer(int header)
    : AbstractSerializer<CameraPurchaseOKMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CameraPurchaseOKMessageComposer message)
    {
        //
    }
}
