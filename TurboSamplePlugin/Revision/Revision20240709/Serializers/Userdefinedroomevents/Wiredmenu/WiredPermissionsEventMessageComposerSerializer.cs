using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredPermissionsEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredPermissionsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredPermissionsEventMessageComposer message
    )
    {
        //
    }
}
