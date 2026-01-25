using Turbo.Primitives.Messages.Outgoing.Handshake;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Handshake;

internal class IsFirstLoginOfDayMessageSerializer(int header)
    : AbstractSerializer<IsFirstLoginOfDayMessage>(header)
{
    protected override void Serialize(IServerPacket packet, IsFirstLoginOfDayMessage message)
    {
        packet.WriteBoolean(message.IsFirstLoginOfDay);
    }
}
