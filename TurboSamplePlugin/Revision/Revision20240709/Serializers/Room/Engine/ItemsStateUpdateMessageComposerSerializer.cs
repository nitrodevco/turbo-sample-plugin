using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ItemsStateUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<ItemsStateUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ItemsStateUpdateMessageComposer message)
    {
        //
    }
}
