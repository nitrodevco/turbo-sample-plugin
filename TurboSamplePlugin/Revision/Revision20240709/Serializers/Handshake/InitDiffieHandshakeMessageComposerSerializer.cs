using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class InitDiffieHandshakeMessageComposerSerializer(int header)
    : AbstractSerializer<InitDiffieHandshakeMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        InitDiffieHandshakeMessageComposer message
    )
    {
        //
    }
}
