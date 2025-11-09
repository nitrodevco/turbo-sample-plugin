using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Landingview.Votes;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Landingview.Votes;

internal class CommunityGoalVoteMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CommunityGoalVoteMessage();
}
