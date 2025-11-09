using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class GetSellablePetPalettesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetSellablePetPalettesMessage { LocalizationId = packet.PopInt() };
}
