using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Competition;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Competition;

internal class IsUserPartOfCompetitionMessageComposerSerializer(int header)
    : AbstractSerializer<IsUserPartOfCompetitionMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        IsUserPartOfCompetitionMessageComposer message
    )
    {
        //
    }
}
