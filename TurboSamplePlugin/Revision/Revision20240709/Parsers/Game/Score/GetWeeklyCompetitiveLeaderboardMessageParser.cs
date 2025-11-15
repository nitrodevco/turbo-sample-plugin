using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Score;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Score;

internal class GetWeeklyCompetitiveLeaderboardMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetWeeklyCompetitiveLeaderboardMessage();
}
