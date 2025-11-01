using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

internal class RoomChatSettingsSerializer
{
    public static void Serialize(IServerPacket packet, ChatSettingsSnapshot message)
    {
        packet.WriteInteger((int)message.ChatMode);
        packet.WriteInteger((int)message.BubbleWidth);
        packet.WriteInteger((int)message.ScrollSpeed);
        packet.WriteInteger(message.FullHearRange);
        packet.WriteInteger((int)message.FloodSensitivity);
    }
}
