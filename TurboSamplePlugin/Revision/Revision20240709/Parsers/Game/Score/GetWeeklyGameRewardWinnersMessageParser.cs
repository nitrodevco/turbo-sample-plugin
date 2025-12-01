using Turbo.Primitives.Messages.Incoming.Game.Score;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Score;

internal class GetWeeklyGameRewardWinnersMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetWeeklyGameRewardWinnersMessage();
}
