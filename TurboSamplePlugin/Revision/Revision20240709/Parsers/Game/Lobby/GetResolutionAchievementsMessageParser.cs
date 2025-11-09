using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Lobby;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Lobby;

internal class GetResolutionAchievementsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetResolutionAchievementsMessage();
}
