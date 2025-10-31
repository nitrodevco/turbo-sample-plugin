using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class SeasonalCalendarDailyOfferMessageComposerSerializer(int header)
    : AbstractSerializer<SeasonalCalendarDailyOfferMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        SeasonalCalendarDailyOfferMessageComposer message
    )
    {
        //
    }
}
