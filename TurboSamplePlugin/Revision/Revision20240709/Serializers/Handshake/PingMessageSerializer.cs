using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class PingMessageSerializer(int header) : AbstractSerializer<PingMessage>(header)
{
    protected override void Serialize(IServerPacket packet, PingMessage message)
    {
        //
    }
}
