using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

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
