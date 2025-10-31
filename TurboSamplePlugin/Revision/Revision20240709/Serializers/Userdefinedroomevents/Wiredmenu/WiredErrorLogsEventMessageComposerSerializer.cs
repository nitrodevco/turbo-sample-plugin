using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredErrorLogsEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredErrorLogsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredErrorLogsEventMessageComposer message
    )
    {
        //
    }
}
