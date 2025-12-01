using Turbo.Primitives.Messages.Incoming.Game.Arena;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Arena;

internal class Game2GameChatMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2GameChatMessage();
}
