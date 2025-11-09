using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Score;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Score;

internal class Game2GetTotalLeaderboardMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2GetTotalLeaderboardMessage();
}
