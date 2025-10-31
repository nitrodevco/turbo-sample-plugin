using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredFurniConditionEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniConditionEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniConditionEventMessageComposer message
    )
    {
        //
    }
}
