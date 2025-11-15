using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

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
