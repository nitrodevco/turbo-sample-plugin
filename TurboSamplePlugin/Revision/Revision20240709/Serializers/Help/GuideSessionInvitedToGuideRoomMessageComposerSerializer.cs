using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

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
