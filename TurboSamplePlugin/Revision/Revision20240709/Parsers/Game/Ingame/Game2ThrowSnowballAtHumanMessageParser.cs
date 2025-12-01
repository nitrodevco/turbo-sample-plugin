using Turbo.Primitives.Messages.Incoming.Game.Ingame;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Ingame;

internal class Game2ThrowSnowballAtHumanMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new Game2ThrowSnowballAtHumanMessage();
}
