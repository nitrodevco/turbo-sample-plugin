using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class ChatReviewSessionDetachedMessageComposerSerializer(int header)
    : AbstractSerializer<ChatReviewSessionDetachedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChatReviewSessionDetachedMessageComposer message
    )
    {
        //
    }
}
