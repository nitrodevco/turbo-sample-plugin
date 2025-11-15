using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Lobby;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Lobby;

internal class GetUserGameAchievementsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetUserGameAchievementsMessage();
}
