using Turbo.Primitives.Messages.Outgoing.Inventory.Trading;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Trading;

internal class TradingYouAreNotAllowedEventMessageComposerSerializer(int header)
    : AbstractSerializer<TradingYouAreNotAllowedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TradingYouAreNotAllowedEventMessageComposer message
    )
    {
        //
    }
}
