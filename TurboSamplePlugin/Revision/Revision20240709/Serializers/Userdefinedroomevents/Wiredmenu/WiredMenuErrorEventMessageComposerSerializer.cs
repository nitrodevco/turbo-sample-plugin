using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredMenuErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredMenuErrorEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredMenuErrorEventMessageComposer message
    )
    {
        //
    }
}
