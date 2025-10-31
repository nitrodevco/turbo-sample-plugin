using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Engine;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;

internal class ItemStateUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<ItemStateUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ItemStateUpdateMessageComposer message)
    {
        //
    }
}
