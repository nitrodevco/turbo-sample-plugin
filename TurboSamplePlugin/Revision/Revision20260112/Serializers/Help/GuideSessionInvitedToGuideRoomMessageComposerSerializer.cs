using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

internal class GuideSessionInvitedToGuideRoomMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionInvitedToGuideRoomMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionInvitedToGuideRoomMessageComposer message
    )
    {
        //
    }
}
