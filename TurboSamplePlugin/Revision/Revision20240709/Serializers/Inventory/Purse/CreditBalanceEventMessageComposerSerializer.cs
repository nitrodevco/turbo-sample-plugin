using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Purse;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Purse;

internal class CreditBalanceEventMessageComposerSerializer(int header)
    : AbstractSerializer<CreditBalanceEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CreditBalanceEventMessageComposer message
    )
    {
        //
    }
}
