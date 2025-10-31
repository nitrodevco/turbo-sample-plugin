using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Bots;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Bots;

internal class BotInventoryEventMessageComposerSerializer(int header)
    : AbstractSerializer<BotInventoryEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BotInventoryEventMessageComposer message
    )
    {
        //
    }
}
