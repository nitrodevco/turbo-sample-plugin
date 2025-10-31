using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Talent;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Talent;

internal class TalentLevelUpMessageComposerSerializer(int header)
    : AbstractSerializer<TalentLevelUpMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TalentLevelUpMessageComposer message)
    {
        //
    }
}
