using Turbo.Primitives.Messages.Incoming.Game.Directory;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Game.Directory;

internal class Game2StartSnowWarMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2StartSnowWarMessage();
}
