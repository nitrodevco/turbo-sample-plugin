using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Competition;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Competition;

internal class CompetitionVotingInfoMessageComposerSerializer(int header)
    : AbstractSerializer<CompetitionVotingInfoMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CompetitionVotingInfoMessageComposer message
    )
    {
        //
    }
}
