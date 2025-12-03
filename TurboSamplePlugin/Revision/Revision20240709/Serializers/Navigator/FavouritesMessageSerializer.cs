using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class FavouritesMessageSerializer(int header)
    : AbstractSerializer<FavouritesMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FavouritesMessageComposer message)
    {
        packet.WriteInteger(message.Limit).WriteInteger(message.FavoriteRoomIds.Length);

        foreach (var roomId in message.FavoriteRoomIds)
            packet.WriteInteger(roomId);
    }
}
