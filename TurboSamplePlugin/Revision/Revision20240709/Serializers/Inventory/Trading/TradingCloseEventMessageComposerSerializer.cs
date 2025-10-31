using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradingCloseEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingCloseEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingCloseEventMessageComposer message
    )
    {
        //
    }
}
