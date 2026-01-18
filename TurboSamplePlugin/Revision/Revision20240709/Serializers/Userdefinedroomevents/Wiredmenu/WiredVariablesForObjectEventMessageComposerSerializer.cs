using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredVariablesForObjectEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredVariablesForObjectEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredVariablesForObjectEventMessageComposer message
    )
    {
        packet
            .WriteInteger((int)message.TargetType)
            .WriteInteger(message.TargetId)
            .WriteInteger(message.VariableValues.Count);

        foreach (var (id, value) in message.VariableValues)
        {
            packet.WriteLong((long)id).WriteInteger(value);
        }
    }
}
