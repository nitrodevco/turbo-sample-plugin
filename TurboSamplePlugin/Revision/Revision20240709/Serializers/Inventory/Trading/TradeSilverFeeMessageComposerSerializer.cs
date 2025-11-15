using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradeSilverFeeMessageComposerSerializer(int header)
    : AbstractSerializer<TradeSilverFeeMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, TradeSilverFeeMessageComposer message)
    {
        //
    }
}
