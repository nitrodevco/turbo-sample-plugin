using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class FavouriteChangedMessageComposerSerializer(int header)
    : AbstractSerializer<FavouriteChangedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FavouriteChangedMessageComposer message)
    {
        packet.WriteInteger(message.RoomId).WriteBoolean(message.Added);
    }
}
