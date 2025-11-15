using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;

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
