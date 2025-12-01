using Turbo.Primitives.Messages.Incoming.Game.Directory;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Directory;

internal class Game2QuickJoinGameMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2QuickJoinGameMessage();
}
