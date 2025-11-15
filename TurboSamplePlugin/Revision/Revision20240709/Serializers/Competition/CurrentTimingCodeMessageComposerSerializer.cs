using Turbo.Primitives.Messages.Outgoing.Competition;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Competition;

internal class CurrentTimingCodeMessageComposerSerializer(int header)
    : AbstractSerializer<CurrentTimingCodeMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CurrentTimingCodeMessageComposer message
    )
    {
        //
    }
}
