using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredFurniTriggerEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniTriggerEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniTriggerEventMessageComposer message
    )
    {
        //
    }
}
