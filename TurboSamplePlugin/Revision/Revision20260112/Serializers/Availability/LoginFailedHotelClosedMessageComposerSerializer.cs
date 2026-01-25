using Turbo.Primitives.Messages.Outgoing.Availability;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Availability;

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
