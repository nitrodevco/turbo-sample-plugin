using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Trading;

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
