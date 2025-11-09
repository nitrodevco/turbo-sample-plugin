using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class RoomRatingMessageComposerSerializer(int header)
    : AbstractSerializer<RoomRatingMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomRatingMessageComposer message)
    {
        packet.WriteInteger(message.Rating).WriteBoolean(message.CanRate);
    }
}
