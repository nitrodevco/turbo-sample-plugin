using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class InitDiffieHandshakeSerializer(int header)
    : AbstractSerializer<InitDiffieHandshakeMessage>(header)
{
    protected override void Serialize(IServerPacket packet, InitDiffieHandshakeMessage composer) =>
        packet.WriteString(composer.Prime).WriteString(composer.Generator);
}
