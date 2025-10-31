using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredVariablesForObjectEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredVariablesForObjectEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredVariablesForObjectEventMessageComposer message
    )
    {
        //
    }
}
