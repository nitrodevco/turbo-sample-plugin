using Turbo.Primitives.Messages.Outgoing.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Help;

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
