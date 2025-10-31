using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Talent;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Talent;

internal class TalentTrackLevelMessageComposerSerializer(int header)
    : AbstractSerializer<TalentTrackLevelMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TalentTrackLevelMessageComposer message)
    {
        //
    }
}
