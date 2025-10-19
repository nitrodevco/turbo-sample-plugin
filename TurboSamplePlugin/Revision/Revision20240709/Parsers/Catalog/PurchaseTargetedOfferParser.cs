using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class PurchaseTargetedOfferParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PurchaseTargetedOfferMessage { OfferId = packet.PopInt(), Quantity = packet.PopInt() };
}
