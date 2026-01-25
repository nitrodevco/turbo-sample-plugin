using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Userdefinedroomevents.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Userdefinedroomevents;

internal class WiredFurniTriggerEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniTriggerEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniTriggerEventMessageComposer message
    )
    {
        WiredDataSerializer.Serialize(packet, message.WiredData);
    }
}
