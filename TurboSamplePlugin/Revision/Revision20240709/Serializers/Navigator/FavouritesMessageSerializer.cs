using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class FavouritesMessageSerializer(int header)
    : AbstractSerializer<FavouritesMessage>(header)
{
    protected override void Serialize(IServerPacket packet, FavouritesMessage message)
    {
        packet.WriteInteger(message.FavoriteRoomIds.Count);

        foreach (var roomId in message.FavoriteRoomIds)
            packet.WriteInteger(roomId);
    }
}
