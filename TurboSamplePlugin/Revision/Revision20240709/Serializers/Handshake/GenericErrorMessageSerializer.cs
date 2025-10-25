using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class GenericErrorMessageSerializer(int header)
    : AbstractSerializer<GenericErrorMessage>(header)
{
    protected override void Serialize(IServerPacket packet, GenericErrorMessage message)
    {
        packet.WriteInteger((int)message.ErrorCode);
    }
}
