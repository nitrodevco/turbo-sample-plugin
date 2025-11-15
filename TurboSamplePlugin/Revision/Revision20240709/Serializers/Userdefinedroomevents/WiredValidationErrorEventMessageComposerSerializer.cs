using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredValidationErrorEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredValidationErrorEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredValidationErrorEventMessageComposer message
    )
    {
        //
    }
}
