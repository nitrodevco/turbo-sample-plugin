using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Userdefinedroomevents;

internal class WiredRewardResultMessageComposerSerializer(int header)
    : AbstractSerializer<WiredRewardResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredRewardResultMessageComposer message
    )
    {
        //
    }
}
