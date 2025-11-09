using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class GetCatalogPageMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetCatalogPageMessage
        {
            PageId = packet.PopInt(),
            OfferId = packet.PopInt(),
            CatalogType = CatalogTypeEnumExtensions.FromLegacyString(packet.PopString()),
        };
}
