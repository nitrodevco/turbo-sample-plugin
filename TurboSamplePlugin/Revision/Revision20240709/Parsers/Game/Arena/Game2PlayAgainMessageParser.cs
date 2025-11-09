using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Game.Arena;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Arena;

internal class Game2PlayAgainMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2PlayAgainMessage();
}
