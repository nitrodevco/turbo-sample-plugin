using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class UniqueMachineIdMessageSerializer(int header)
    : AbstractSerializer<UniqueMachineIdMessage>(header)
{
    protected override void Serialize(IServerPacket packet, UniqueMachineIdMessage message)
    {
        //
    }
}
