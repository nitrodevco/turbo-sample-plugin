using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Navigator;

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
