using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Campaign;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Campaign;

internal class CampaignCalendarDoorOpenedMessageComposerSerializer(int header)
    : AbstractSerializer<CampaignCalendarDoorOpenedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CampaignCalendarDoorOpenedMessageComposer message
    )
    {
        //
    }
}
