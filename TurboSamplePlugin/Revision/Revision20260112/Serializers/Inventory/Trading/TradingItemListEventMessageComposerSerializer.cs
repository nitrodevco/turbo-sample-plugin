using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Trading;

internal class TradingItemListEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingItemListEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingItemListEventMessageComposer message
    )
    {
        //
    }
}
