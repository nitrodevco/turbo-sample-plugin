using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

internal class WiredSaveSuccessEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredSaveSuccessEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredSaveSuccessEventMessageComposer message
    )
    {
        //
    }
}
