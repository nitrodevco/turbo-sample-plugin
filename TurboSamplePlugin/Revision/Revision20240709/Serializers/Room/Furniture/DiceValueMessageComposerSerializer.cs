using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class DiceValueMessageComposerSerializer(int header)
    : AbstractSerializer<DiceValueMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, DiceValueMessageComposer message)
    {
        packet.WriteInteger(message.FurniId).WriteInteger(message.Value);
    }
}
