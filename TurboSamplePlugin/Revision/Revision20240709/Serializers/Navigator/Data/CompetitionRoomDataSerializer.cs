using Turbo.Packets.Abstractions;
using Turbo.Primitives.Snapshots.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

internal class CompetitionRoomDataSerializer
{
    public static void Serialize(IServerPacket packet, CompetitionRoomDataSnapshot message)
    {
        packet.WriteInteger(message.GoalId);
        packet.WriteInteger(message.PageIndex);
        packet.WriteInteger(message.PageCount);
    }
}
