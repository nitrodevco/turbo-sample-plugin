using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Landingview;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Landingview;

internal class GetPromoArticlesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetPromoArticlesMessage();
}
