using Turbo.Packets.Abstractions;
using Turbo.Primitives.Orleans.Snapshots.Room.Settings;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

internal class ModSettingsSnapshotSerializer
{
    public static void Serialize(IServerPacket packet, ModSettingsSnapshot message)
    {
        packet.WriteInteger((int)message.WhoCanMute);
        packet.WriteInteger((int)message.WhoCanKick);
        packet.WriteInteger((int)message.WhoCanBan);
    }
}
