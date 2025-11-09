using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Score;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Score;

internal class GetWeeklyGameRewardMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetWeeklyGameRewardMessage();
}
