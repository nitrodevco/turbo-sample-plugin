using Turbo.Primitives.Messages.Incoming.Game.Score;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Score;

internal class GetWeeklyGameRewardMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetWeeklyGameRewardMessage();
}
