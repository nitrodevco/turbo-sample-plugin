using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradingOtherNotAllowedEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingOtherNotAllowedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingOtherNotAllowedEventMessageComposer message
    )
    {
        //
    }
}
