using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Help;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Help;

internal class ChatReviewSessionVotingStatusMessageComposerSerializer(int header)
    : AbstractSerializer<ChatReviewSessionVotingStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ChatReviewSessionVotingStatusMessageComposer message
    )
    {
        //
    }
}
