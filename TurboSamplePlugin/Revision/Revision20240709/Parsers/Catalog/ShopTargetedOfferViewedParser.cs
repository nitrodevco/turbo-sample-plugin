using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class ShopTargetedOfferViewedParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new ShopTargetedOfferViewedMessage
        {
            TargetedOfferId = packet.PopInt(),
            TrackingState = packet.PopInt(),
        };
}
