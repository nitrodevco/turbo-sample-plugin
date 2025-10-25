using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class NoobnessLevelMessageSerializer(int header)
    : AbstractSerializer<NoobnessLevelMessage>(header)
{
    protected override void Serialize(IServerPacket packet, NoobnessLevelMessage message)
    {
        packet.WriteInteger((int)message.NoobnessLevel);
    }
}
