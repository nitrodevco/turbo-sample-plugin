using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredFurniVariableEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniVariableEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniVariableEventMessageComposer message
    )
    {
        WiredDataSerializer.Serialize(packet, message.WiredData);
    }
}
