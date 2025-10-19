using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class GetCatalogPageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetCatalogPageMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            Type = packet.PopString(),
        };
}
