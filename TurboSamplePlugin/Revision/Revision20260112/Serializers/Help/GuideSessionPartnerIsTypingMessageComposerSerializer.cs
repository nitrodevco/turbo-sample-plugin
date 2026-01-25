using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

internal class GuideSessionPartnerIsTypingMessageComposerSerializer(int header)
    : AbstractSerializer<GuideSessionPartnerIsTypingMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuideSessionPartnerIsTypingMessageComposer message
    )
    {
        //
    }
}
