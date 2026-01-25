using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Trading;

internal class TradingCompletedEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingCompletedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingCompletedEventMessageComposer message
    )
    {
        //
    }
}
