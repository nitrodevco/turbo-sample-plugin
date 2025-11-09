using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class PurchaseTargetedOfferMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PurchaseTargetedOfferMessage { OfferId = packet.PopInt(), Quantity = packet.PopInt() };
}
