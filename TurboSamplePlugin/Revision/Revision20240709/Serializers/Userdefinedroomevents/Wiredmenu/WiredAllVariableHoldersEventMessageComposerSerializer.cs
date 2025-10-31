using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredAllVariableHoldersEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredAllVariableHoldersEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredAllVariableHoldersEventMessageComposer message
    )
    {
        //
    }
}
