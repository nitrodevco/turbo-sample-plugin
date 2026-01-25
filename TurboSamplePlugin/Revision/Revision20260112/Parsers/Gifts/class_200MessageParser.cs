using Turbo.Primitives.Messages.Incoming.Gifts;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Gifts;

internal class class_200MessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new class_200Message();
}
