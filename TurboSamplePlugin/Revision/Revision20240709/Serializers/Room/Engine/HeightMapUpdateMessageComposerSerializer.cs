using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class HeightMapUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<HeightMapUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, HeightMapUpdateMessageComposer message)
    {
        packet.WriteByte((byte)message.Tiles.Length);

        foreach (var tile in message.Tiles)
            packet.WriteByte(tile.X).WriteByte(tile.Y).WriteShort(tile.RelativeHeight);
    }
}
