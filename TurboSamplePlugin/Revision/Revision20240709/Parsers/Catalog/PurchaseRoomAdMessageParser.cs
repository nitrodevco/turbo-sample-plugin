using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class PurchaseRoomAdMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PurchaseRoomAdMessageMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            FlatId = packet.PopInt(),
            Name = packet.PopString(),
            Extended = packet.PopBoolean(),
            Description = packet.PopString(),
            CategoryId = packet.PopInt(),
        };
}
