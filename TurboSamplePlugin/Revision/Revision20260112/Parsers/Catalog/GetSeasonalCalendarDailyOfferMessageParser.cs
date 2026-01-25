using Turbo.Primitives.Messages.Incoming.Catalog;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Catalog;

internal class GetSeasonalCalendarDailyOfferMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetSeasonalCalendarDailyOfferMessage();
}
