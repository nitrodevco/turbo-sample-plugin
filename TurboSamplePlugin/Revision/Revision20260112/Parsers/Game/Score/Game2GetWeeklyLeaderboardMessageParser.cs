using Turbo.Primitives.Messages.Incoming.Game.Score;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Game.Score;

internal class Game2GetWeeklyLeaderboardMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2GetWeeklyLeaderboardMessage();
}
