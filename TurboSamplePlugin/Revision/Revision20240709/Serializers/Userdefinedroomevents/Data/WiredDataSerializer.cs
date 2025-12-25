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

        foreach (var furniSourceType in snapshot.FurniSourceTypes)
            packet.WriteInteger(furniSourceType);

        packet.WriteInteger(snapshot.UserSourceTypes.Count);

        foreach (var userSourceType in snapshot.UserSourceTypes)
            packet.WriteInteger(userSourceType);

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
        SerializeAllowedSources(packet, snapshot);
        SerializeAllowedSources(packet, snapshot);
        SerializeDefaultSources(packet, snapshot);
        SerializeDefaultSources(packet, snapshot);
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

    private static void SerializeAllowedSources(IServerPacket packet, WiredDataSnapshot snapshot)
    {
        packet.WriteInteger(snapshot.FurniSourceTypes.Count);

        foreach (var furniSourceType in snapshot.FurniSourceTypes)
            packet.WriteInteger(furniSourceType);
    }

    private static void SerializeDefaultSources(IServerPacket packet, WiredDataSnapshot snapshot)
    {
        packet.WriteInteger(snapshot.FurniSourceTypes.Count);

        foreach (var furniSourceType in snapshot.FurniSourceTypes)
            packet.WriteInteger(furniSourceType);
    }
}
