using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredFurniAddonEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredFurniAddonEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredFurniAddonEventMessageComposer message
    )
    {
        //
    }
}
