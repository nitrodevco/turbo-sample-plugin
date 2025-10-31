using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Bots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Bots;

internal class BotRemovedFromInventoryEventMessageComposerSerializer(int header)
    : AbstractSerializer<BotRemovedFromInventoryEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BotRemovedFromInventoryEventMessageComposer message
    )
    {
        //
    }
}
