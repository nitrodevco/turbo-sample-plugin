using Turbo.Primitives.Messages.Incoming.Landingview.Votes;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Landingview.Votes;

internal class CommunityGoalVoteMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CommunityGoalVoteMessage();
}
