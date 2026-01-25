using Turbo.Primitives.Messages.Incoming.Game.Score;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Game.Score;

internal class GetWeeklyCompetitiveLeaderboardMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetWeeklyCompetitiveLeaderboardMessage();
}
