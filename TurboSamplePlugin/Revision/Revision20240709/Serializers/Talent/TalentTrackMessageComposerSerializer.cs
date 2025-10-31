using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Talent;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Talent;

internal class TalentTrackMessageComposerSerializer(int header)
    : AbstractSerializer<TalentTrackMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TalentTrackMessageComposer message)
    {
        //
    }
}
