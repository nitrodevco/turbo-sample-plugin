using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Ingame;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Ingame;

internal class Game2SetUserMoveTargetMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2SetUserMoveTargetMessage();
}
