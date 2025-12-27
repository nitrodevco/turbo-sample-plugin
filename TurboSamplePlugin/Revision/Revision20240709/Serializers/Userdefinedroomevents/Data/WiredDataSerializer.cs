using Microsoft.CodeAnalysis.CSharp.Syntax;
using Turbo.Primitives.Furniture.Snapshots.WiredData;
using Turbo.Primitives.Packets;

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

        foreach (var furniSourceType in snapshot.FurniSourceTypes.Values)
            packet.WriteInteger((int)furniSourceType);

        packet.WriteInteger(snapshot.UserSourceTypes.Count);

        foreach (var userSourceType in snapshot.UserSourceTypes.Values)
            packet.WriteInteger((int)userSourceType);

        packet.WriteInteger(snapshot.Code);

        SerializeDefinitionSpecifics(packet, snapshot);

        packet.WriteBoolean(snapshot.AdvancedMode);

        SerializeInputSources(packet, snapshot);

        packet.WriteBoolean(snapshot.AllowWallFurni);

        SerializeTypeSpecifics(packet, snapshot);

        // wired context
    }

    private static void SerializeDefinitionSpecifics(
        IServerPacket packet,
        WiredDataSnapshot snapshot
    )
    {
        switch (snapshot)
        {
            case WiredDataConditionSnapshot conditionSnapshot:
                packet.WriteInteger(conditionSnapshot.QuantifierCode);
                break;
            case WiredDataActionSnapshot actionSnapshot:
                packet.WriteInteger(actionSnapshot.DelayInPulses);
                break;
            case WiredDataSelectorSnapshot selectorSnapshot:
                packet
                    .WriteBoolean(selectorSnapshot.IsFilter)
                    .WriteBoolean(selectorSnapshot.IsInvert);
                break;
        }
    }

    private static void SerializeInputSources(IServerPacket packet, WiredDataSnapshot snapshot)
    {
        packet.WriteInteger(snapshot.AllowedFurniSources.Count);

        foreach (var furniSourceList in snapshot.AllowedFurniSources)
        {
            packet.WriteInteger(furniSourceList.Length);

            foreach (var furniSourceId in furniSourceList)
                packet.WriteInteger((int)furniSourceId);
        }

        packet.WriteInteger(snapshot.AllowedUserSources.Count);

        foreach (var userSourceList in snapshot.AllowedUserSources)
        {
            packet.WriteInteger(userSourceList.Length);

            foreach (var userSourceId in userSourceList)
                packet.WriteInteger((int)userSourceId);
        }

        packet.WriteInteger(snapshot.AllowedFurniSources.Count);

        foreach (var types in snapshot.AllowedFurniSources)
        {
            foreach (var type in types)
            {
                packet.WriteInteger((int)type);

                break;
            }
        }

        packet.WriteInteger(snapshot.AllowedUserSources.Count);

        foreach (var types in snapshot.AllowedUserSources)
        {
            foreach (var type in types)
            {
                packet.WriteInteger((int)type);

                break;
            }
        }
    }

    private static void SerializeTypeSpecifics(IServerPacket packet, WiredDataSnapshot snapshot)
    {
        switch (snapshot)
        {
            case WiredDataConditionSnapshot conditionSnapshot:
                packet
                    .WriteByte((byte)conditionSnapshot.QuantifierType)
                    .WriteBoolean(conditionSnapshot.IsInvert);
                break;
        }
    }
}
