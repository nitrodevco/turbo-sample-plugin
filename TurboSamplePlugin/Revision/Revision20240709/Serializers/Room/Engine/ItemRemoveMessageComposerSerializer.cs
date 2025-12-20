using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ItemRemoveMessageComposerSerializer(int header)
    : AbstractSerializer<ItemRemoveMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ItemRemoveMessageComposer message)
    {
        packet.WriteString(message.ObjectId.ToString()).WriteInteger(message.PickerId);
    }
}
