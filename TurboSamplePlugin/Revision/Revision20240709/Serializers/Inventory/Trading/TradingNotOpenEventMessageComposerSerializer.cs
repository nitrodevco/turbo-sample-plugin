using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradingNotOpenEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingNotOpenEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingNotOpenEventMessageComposer message
    )
    {
        //
    }
}
