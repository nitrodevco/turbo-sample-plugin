using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Quest;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Quest;

internal class class_735MessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new class_735Message();
}
