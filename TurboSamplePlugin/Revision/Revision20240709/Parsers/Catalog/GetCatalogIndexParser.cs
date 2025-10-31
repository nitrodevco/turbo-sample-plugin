using Turbo.Contracts.Abstractions;
using Turbo.Contracts.Enums.Catalog;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

public class GetCatalogIndexParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetCatalogIndexMessage
        {
            CatalogType = CatalogTypeEnumExtensions.FromLegacyString(packet.PopString()),
        };
}
