using System.Collections.Generic;
using Turbo.Primitives.Furniture.Snapshots.WiredData;
using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Enums.Wired;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Data;

internal class WiredDataSerializer
{
    public static void Serialize(IServerPacket packet, WiredDataSnapshot snapshot)
    {
        packet.WriteInteger(snapshot.FurniLimit).WriteInteger(snapshot.StuffIds.Count);

        foreach (var stuffId in snapshot.StuffIds)
            packet.WriteInteger(stuffId);

        packet
            .WriteInteger(snapshot.StuffTypeId)
            .WriteInteger(snapshot.Id)
            .WriteString(snapshot.StringParam)
            .WriteInteger(snapshot.IntParams.Count);

        foreach (var intParam in snapshot.IntParams)
            packet.WriteInteger(intParam);

        packet.WriteInteger(snapshot.VariableIds.Count);

        foreach (var variableId in snapshot.VariableIds)
            packet.WriteLong(variableId);

        packet.WriteInteger(snapshot.FurniSourceTypes.Count);

        foreach (var furniSourceType in snapshot.FurniSourceTypes)
            packet.WriteInteger(
                (int)WiredFurniSourceTypeExtensions.GetProtocolId(furniSourceType[0])
            );

        packet.WriteInteger(snapshot.PlayerSourceTypes.Count);

        foreach (var userSourceType in snapshot.PlayerSourceTypes)
            packet.WriteInteger(
                (int)WiredPlayerSourceTypeExtensions.GetProtocolId(userSourceType[0])
            );

        packet.WriteInteger(snapshot.Code);

        SerializeSpecifics(packet, snapshot.DefinitionSpecifics);

        packet.WriteBoolean(snapshot.AdvancedMode);

        SerializeInputSources(packet, snapshot);

        packet.WriteBoolean(snapshot.AllowWallFurni);

        SerializeSpecifics(packet, snapshot.TypeSpecifics);

        packet
            .WriteInteger(1)
            .WriteInteger((int)WiredContextType.AllVariablesInRoom)
            .WriteInteger(snapshot.GlobalHash);
    }

    private static void SerializeSpecifics(IServerPacket packet, List<object> specifics)
    {
        foreach (var specific in specifics)
        {
            if (specific is null)
                continue;

            switch (specific)
            {
                case int intValue:
                    packet.WriteInteger(intValue);
                    break;
                case string stringValue:
                    packet.WriteString(stringValue);
                    break;
                case bool boolValue:
                    packet.WriteBoolean(boolValue);
                    break;
                case byte byteValue:
                    packet.WriteByte(byteValue);
                    break;
                default:
                    break;
            }
        }
    }

    private static void SerializeInputSources(IServerPacket packet, WiredDataSnapshot snapshot)
    {
        packet.WriteInteger(snapshot.AllowedFurniSources.Count);

        foreach (var furniSourceList in snapshot.AllowedFurniSources)
        {
            packet.WriteInteger(furniSourceList.Length);

            foreach (var furniSourceId in furniSourceList)
                packet.WriteInteger(
                    (int)WiredFurniSourceTypeExtensions.GetProtocolId(furniSourceId)
                );
        }

        packet.WriteInteger(snapshot.AllowedPlayerSources.Count);

        foreach (var userSourceList in snapshot.AllowedPlayerSources)
        {
            packet.WriteInteger(userSourceList.Length);

            foreach (var userSourceId in userSourceList)
                packet.WriteInteger(
                    (int)WiredPlayerSourceTypeExtensions.GetProtocolId(userSourceId)
                );
        }

        packet.WriteInteger(snapshot.DefaultFurniSources.Count);

        foreach (var type in snapshot.DefaultFurniSources)
            packet.WriteInteger((int)WiredFurniSourceTypeExtensions.GetProtocolId(type[0]));

        packet.WriteInteger(snapshot.DefaultPlayerSources.Count);

        foreach (var type in snapshot.DefaultPlayerSources)
            packet.WriteInteger((int)WiredPlayerSourceTypeExtensions.GetProtocolId(type[0]));
    }
}
