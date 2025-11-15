using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ItemUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<ItemUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ItemUpdateMessageComposer message)
    {
        //
    }
}
