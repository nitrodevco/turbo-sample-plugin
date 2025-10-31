using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Bots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Bots;

internal class BotAddedToInventoryEventMessageComposerSerializer(int header)
    : AbstractSerializer<BotAddedToInventoryEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BotAddedToInventoryEventMessageComposer message
    )
    {
        //
    }
}
