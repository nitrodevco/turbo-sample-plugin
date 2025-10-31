using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredFurniVariableEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniVariableEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniVariableEventMessageComposer message
    )
    {
        //
    }
}
