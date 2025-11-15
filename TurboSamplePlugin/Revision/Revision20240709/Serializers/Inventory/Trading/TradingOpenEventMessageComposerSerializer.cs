using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradingOpenEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingOpenEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TradingOpenEventMessageComposer message)
    {
        //
    }
}
