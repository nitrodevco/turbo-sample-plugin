using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class ChatReviewSessionStartedMessageComposerSerializer(int header)
    : AbstractSerializer<ChatReviewSessionStartedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChatReviewSessionStartedMessageComposer message
    )
    {
        //
    }
}
