using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Campaign;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Campaign;

internal class CampaignCalendarDataMessageComposerSerializer(int header)
    : AbstractSerializer<CampaignCalendarDataMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CampaignCalendarDataMessageComposer message
    )
    {
        //
    }
}
