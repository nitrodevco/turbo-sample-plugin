using Turbo.Primitives.Messages.Outgoing.Availability;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Availability;

internal class InfoHotelClosingMessageComposerSerializer(int header)
    : AbstractSerializer<InfoHotelClosingMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, InfoHotelClosingMessageComposer message)
    {
        //
    }
}
