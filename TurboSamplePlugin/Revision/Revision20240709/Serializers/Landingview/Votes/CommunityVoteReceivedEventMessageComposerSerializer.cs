using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Landingview.Votes;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Landingview.Votes;

internal class CommunityVoteReceivedEventMessageComposerSerializer(int header)
    : AbstractSerializer<CommunityVoteReceivedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CommunityVoteReceivedEventMessageComposer message
    )
    {
        //
    }
}
