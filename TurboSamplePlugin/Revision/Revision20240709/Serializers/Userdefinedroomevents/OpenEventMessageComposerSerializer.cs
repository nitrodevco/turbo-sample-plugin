using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class OpenEventMessageComposerSerializer(int header)
    : AbstractSerializer<OpenEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, OpenEventMessageComposer message)
    {
        //
    }
}
