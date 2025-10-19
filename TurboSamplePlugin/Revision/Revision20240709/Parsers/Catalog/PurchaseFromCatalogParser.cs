using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class PurchaseFromCatalogParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PurchaseFromCatalogMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            ExtraParam = packet.PopString(),
            Quantity = packet.PopInt(),
        };
}
