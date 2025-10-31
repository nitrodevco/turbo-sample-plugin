using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Camera;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;

internal class CompetitionStatusMessageComposerSerializer(int header)
    : AbstractSerializer<CompetitionStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CompetitionStatusMessageComposer message
    )
    {
        //
    }
}
