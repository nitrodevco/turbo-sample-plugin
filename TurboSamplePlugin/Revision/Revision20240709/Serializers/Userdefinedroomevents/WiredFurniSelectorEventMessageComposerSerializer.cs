using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredFurniSelectorEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniSelectorEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniSelectorEventMessageComposer message
    )
    {
        //
    }
}
