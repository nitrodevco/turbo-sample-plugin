using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Furniture.StuffData;
using Turbo.Primitives.Rooms.Snapshots.StuffData;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

internal class StuffDataSnapshotSerializer
{
    public static void Serialize(IServerPacket packet, StuffDataSnapshot item)
    {
        packet.WriteInteger(item.StuffBitmask);

        if (item.LegacyPayload is not null)
        {
            packet.WriteString(item.LegacyPayload.Data);
        }
        else if (item.MapPayload is not null)
        {
            packet.WriteInteger(item.MapPayload.Data.Count);

            foreach (var (key, value) in item.MapPayload.Data)
                packet.WriteString(key).WriteString(value);
        }
        else if (item.StringPayload is not null)
        {
            packet.WriteInteger(item.StringPayload.Data.Length);

            foreach (var value in item.StringPayload.Data)
                packet.WriteString(value);
        }
        else if (item.VotePayload is not null)
        {
            packet.WriteString(item.VotePayload.Data).WriteInteger(item.VotePayload.Result);
        }
        else if (item.NumberPayload is not null)
        {
            packet.WriteInteger(item.NumberPayload.Data.Length);

            foreach (var value in item.NumberPayload.Data)
                packet.WriteInteger(value);
        }
        else if (item.HighscorePayload is not null)
        {
            packet
                .WriteString(item.HighscorePayload.Data)
                .WriteInteger(item.HighscorePayload.ScoreType)
                .WriteInteger(item.HighscorePayload.ClearType)
                .WriteInteger(item.HighscorePayload.Scores.Count);

            foreach (var score in item.HighscorePayload.Scores)
            {
                packet.WriteInteger(score.Key).WriteInteger(score.Value.Length);

                foreach (var name in score.Value)
                    packet.WriteString(name);
            }
        }

        if ((item.StuffBitmask & (int)StuffDataFlags.Unique) != 0)
            packet.WriteInteger(item.UniqueNumber).WriteInteger(item.UniqueSeries);
    }

    public static void SerializeLegacyString(IServerPacket packet, StuffDataSnapshot item)
    {
        var legacyString = string.Empty;

        if (item.LegacyPayload is not null)
        {
            legacyString = item.LegacyPayload.Data;
        }
        else if (item.MapPayload is not null)
        {
            legacyString = item.MapPayload.Data["state"];
        }
        else if (item.NumberPayload is not null)
        {
            legacyString = item.NumberPayload.Data[0].ToString();
        }
        else if (item.StringPayload is not null)
        {
            legacyString = item.StringPayload.Data[0];
        }

        packet.WriteString(legacyString);
    }
}
