using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredAllVariablesDiffsEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredAllVariablesDiffsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredAllVariablesDiffsEventMessageComposer message
    )
    {
        packet
            .WriteInteger((int)message.AllVariablesHash)
            .WriteBoolean(message.IsLastChunk)
            .WriteInteger(message.RemovedVariables.Count);

        foreach (var removedVariable in message.RemovedVariables)
            packet.WriteLong(removedVariable);

        packet.WriteInteger(message.AddedOrUpdated.Count);

        foreach (var snapshot in message.AddedOrUpdated)
        {
            packet.WriteInteger((int)snapshot.VariableHash);

            WiredVariableSerializer.Serialize(packet, snapshot);
        }
    }
}
