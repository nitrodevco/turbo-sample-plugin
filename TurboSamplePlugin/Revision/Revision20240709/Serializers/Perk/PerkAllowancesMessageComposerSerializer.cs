using Turbo.Primitives.Messages.Outgoing.Perk;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Perk;

internal class PerkAllowancesMessageComposerSerializer(int header)
    : AbstractSerializer<PerkAllowancesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PerkAllowancesMessageComposer message)
    {
        //
    }
}
