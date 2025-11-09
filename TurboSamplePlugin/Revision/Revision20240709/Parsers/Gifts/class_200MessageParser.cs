using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Gifts;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Gifts;

internal class class_200MessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new class_200Message();
}
