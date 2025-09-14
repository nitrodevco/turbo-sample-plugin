using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

public class InitDiffieHandshakeSerializer(int header)
    : AbstractSerializer<InitDiffieHandshakeComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InitDiffieHandshakeComposer composer) =>
        packet.WriteString(composer.Prime).WriteString(composer.Generator);
}
