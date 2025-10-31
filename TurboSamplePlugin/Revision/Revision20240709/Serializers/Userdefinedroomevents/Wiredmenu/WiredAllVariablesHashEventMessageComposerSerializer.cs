using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredAllVariablesHashEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredAllVariablesHashEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredAllVariablesHashEventMessageComposer message
    )
    {
        //
    }
}
