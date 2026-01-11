using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredAllVariableHoldersEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredAllVariableHoldersEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredAllVariableHoldersEventMessageComposer message
    )
    {
        WiredVariableSerializer.Serialize(packet, message.VariableSnapshot);

        packet.WriteInteger(0);
    }
}
