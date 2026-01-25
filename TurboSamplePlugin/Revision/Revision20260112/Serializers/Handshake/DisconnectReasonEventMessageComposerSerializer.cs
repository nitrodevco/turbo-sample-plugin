using Turbo.Primitives.Messages.Outgoing.Handshake;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Handshake;

internal class DisconnectReasonEventMessageComposerSerializer(int header)
    : AbstractSerializer<DisconnectReasonEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        DisconnectReasonEventMessageComposer message
    )
    {
        //
    }
}
