using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class GetSeasonalCalendarDailyOfferMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetSeasonalCalendarDailyOfferMessage();
}
