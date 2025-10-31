using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

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
