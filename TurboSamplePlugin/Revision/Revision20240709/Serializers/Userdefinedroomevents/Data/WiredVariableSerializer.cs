using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Snapshots.Wired;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Data;

internal class WiredVariableSerializer
{
    public static void Serialize(IServerPacket packet, WiredVariableSnapshot snapshot)
    {
        packet
            .WriteLong(snapshot.VariableId)
            .WriteString(snapshot.VariableName)
            .WriteInteger((int)snapshot.AvailabilityType)
            .WriteInteger((int)snapshot.VariableType)
            .WriteBoolean(snapshot.AlwaysAvailable)
            .WriteBoolean(snapshot.CanCreateAndDelete)
            .WriteBoolean(snapshot.HasValue)
            .WriteBoolean(snapshot.CanWriteValue)
            .WriteBoolean(snapshot.CanInterceptChanges)
            .WriteBoolean(snapshot.IsInvisible)
            .WriteBoolean(snapshot.CanReadCreationTime)
            .WriteBoolean(snapshot.CanReadLastUpdateTime)
            .WriteBoolean(snapshot.HasTextConnector);

        if (snapshot.HasTextConnector)
        {
            packet.WriteInteger(snapshot.TextConnector.Count);

            foreach (var text in snapshot.TextConnector)
                packet.WriteInteger(text.Length).WriteString(text);
        }
    }
}
