using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents;

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
