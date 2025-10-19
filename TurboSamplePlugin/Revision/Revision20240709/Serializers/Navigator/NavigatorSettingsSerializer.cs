using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

public class NavigatorSettingsSerializer(int header)
    : AbstractSerializer<NavigatorSettingsMessage>(header)
{
    protected override void Serialize(IServerPacket packet, NavigatorSettingsMessage message)
    {
        packet.WriteInteger(message.HomeRoomId).WriteInteger(message.RoomIdToEnter);
    }
}
