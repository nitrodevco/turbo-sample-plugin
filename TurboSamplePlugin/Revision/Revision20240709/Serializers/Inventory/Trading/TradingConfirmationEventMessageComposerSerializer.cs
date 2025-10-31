using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradingConfirmationEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingConfirmationEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingConfirmationEventMessageComposer message
    )
    {
        //
    }
}
