using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class ChatReviewSessionOfferedToGuideMessageComposerSerializer(int header)
    : AbstractSerializer<ChatReviewSessionOfferedToGuideMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChatReviewSessionOfferedToGuideMessageComposer message
    )
    {
        //
    }
}
