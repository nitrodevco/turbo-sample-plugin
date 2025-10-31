using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

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
