using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Directory;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Directory;

internal class Game2LeaveGameMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2LeaveGameMessage();
}
