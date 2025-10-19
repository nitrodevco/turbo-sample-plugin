using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class CompleteDiffieHandshakeSerializer(int header)
    : AbstractSerializer<CompleteDiffieHandshakeComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CompleteDiffieHandshakeComposer message)
    {
        packet.WriteString(message.PublicKey);
        packet.WriteBoolean(message.ServerClientEncryption);
    }
}
