using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredAllVariablesDiffsEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredAllVariablesDiffsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredAllVariablesDiffsEventMessageComposer message
    )
    {
        packet
            .WriteInteger(message.AllVariablesHash.Value)
            .WriteBoolean(message.IsLastChunk)
            .WriteInteger(message.RemovedVariableIds.Count);

        foreach (var removedVariable in message.RemovedVariableIds)
            packet.WriteString(removedVariable.Value);

        packet.WriteInteger(message.AddedOrUpdated.Count);

        foreach (var snapshot in message.AddedOrUpdated)
        {
            packet.WriteInteger(snapshot.VariableHash.Value);

            WiredVariableSerializer.Serialize(packet, snapshot);
        }
    }
}
