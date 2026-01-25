using Turbo.Primitives.Messages.Outgoing.Talent;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Talent;

internal class TalentTrackMessageComposerSerializer(int header)
    : AbstractSerializer<TalentTrackMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TalentTrackMessageComposer message)
    {
        //
    }
}
