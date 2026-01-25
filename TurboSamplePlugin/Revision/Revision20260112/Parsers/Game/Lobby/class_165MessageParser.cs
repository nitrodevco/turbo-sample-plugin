using Turbo.Primitives.Messages.Incoming.Game.Lobby;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Game.Lobby;

internal class class_165MessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new class_165Message();
}
