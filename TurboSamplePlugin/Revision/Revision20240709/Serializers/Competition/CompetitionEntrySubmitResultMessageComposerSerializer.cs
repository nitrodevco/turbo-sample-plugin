using Turbo.Primitives.Messages.Outgoing.Competition;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Competition;

internal class CompetitionEntrySubmitResultMessageComposerSerializer(int header)
    : AbstractSerializer<CompetitionEntrySubmitResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CompetitionEntrySubmitResultMessageComposer message
    )
    {
        //
    }
}
