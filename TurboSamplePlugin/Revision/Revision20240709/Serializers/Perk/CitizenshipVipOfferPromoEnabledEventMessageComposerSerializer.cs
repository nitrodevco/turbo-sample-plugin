using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Perk;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Perk;

internal class CitizenshipVipOfferPromoEnabledEventMessageComposerSerializer(int header)
    : AbstractSerializer<CitizenshipVipOfferPromoEnabledEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CitizenshipVipOfferPromoEnabledEventMessageComposer message
    )
    {
        //
    }
}
