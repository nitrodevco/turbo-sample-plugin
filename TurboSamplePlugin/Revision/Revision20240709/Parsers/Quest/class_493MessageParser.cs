using Turbo.Primitives.Messages.Incoming.Quest;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Quest;

internal class class_493MessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new class_493Message();
}
