using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Handshake;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;

internal class IsFirstLoginOfDaySerializer(int header)
    : AbstractSerializer<IsFirstLoginOfDayMessage>(header)
{
    protected override void Serialize(IServerPacket packet, IsFirstLoginOfDayMessage message)
    {
        packet.WriteBoolean(false);
    }
}
