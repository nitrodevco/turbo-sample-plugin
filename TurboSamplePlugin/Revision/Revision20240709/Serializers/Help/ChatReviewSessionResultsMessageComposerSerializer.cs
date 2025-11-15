using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class ChatReviewSessionResultsMessageComposerSerializer(int header)
    : AbstractSerializer<ChatReviewSessionResultsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChatReviewSessionResultsMessageComposer message
    )
    {
        //
    }
}
