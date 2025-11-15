using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class BonusRareInfoMessageComposerSerializer(int header)
    : AbstractSerializer<BonusRareInfoMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, BonusRareInfoMessageComposer message)
    {
        packet.WriteString(message.ProductType);
        packet.WriteInteger(message.ProductClassId);
        packet.WriteInteger(message.TotalCoinsForBonus);
        packet.WriteInteger(message.CoinsStillRequiredToBuy);
    }
}
