using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

internal class ScrSendUserInfoMessageSerializer(int header)
    : AbstractSerializer<ScrSendUserInfoMessage>(header)
{
    protected override void Serialize(IServerPacket packet, ScrSendUserInfoMessage message)
    {
        packet.WriteString("club_habbo");
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(2);
        packet.WriteBoolean(false);
        packet.WriteBoolean(false);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(0);
        packet.WriteInteger(-1);
    }
}
