using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class HabboClubExtendOfferMessageComposerSerializer(int header)
    : AbstractSerializer<HabboClubExtendOfferMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HabboClubExtendOfferMessageComposer message
    )
    {
        //
    }
}
