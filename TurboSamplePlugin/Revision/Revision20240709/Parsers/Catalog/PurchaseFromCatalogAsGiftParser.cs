using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class PurchaseFromCatalogAsGiftParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PurchaseFromCatalogAsGiftMessage
        {
            PageId = packet.PopInt(),
            OfferCode = packet.PopInt(),
            ExtraParam = packet.PopString(),
            RecieverName = packet.PopString(),
            Message = packet.PopString(),
            BoxStuffTypeId = packet.PopInt(),
            BoxTypeId = packet.PopInt(),
            RibbonTypeId = packet.PopInt(),
            ShowPurchaserName = packet.PopBoolean(),
        };
}
