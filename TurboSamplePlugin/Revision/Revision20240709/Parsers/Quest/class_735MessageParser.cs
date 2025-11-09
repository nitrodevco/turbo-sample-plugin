using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Quest;

internal class class_735MessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new class_735Message();
}
