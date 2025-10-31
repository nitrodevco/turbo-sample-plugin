using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Availability;

internal class InfoHotelClosedMessageComposerSerializer(int header)
    : AbstractSerializer<InfoHotelClosedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InfoHotelClosedMessageComposer message)
    {
        //
    }
}
