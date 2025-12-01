using Turbo.Primitives.Messages.Incoming.Game.Lobby;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Lobby;

internal class GetResolutionAchievementsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetResolutionAchievementsMessage();
}
