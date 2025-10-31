using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Availability;

internal class LoginFailedHotelClosedMessageComposerSerializer(int header)
    : AbstractSerializer<LoginFailedHotelClosedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        LoginFailedHotelClosedMessageComposer message
    )
    {
        //
    }
}
