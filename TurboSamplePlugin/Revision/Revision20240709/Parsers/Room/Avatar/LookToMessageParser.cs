using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Avatar;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Avatar;

internal class LookToMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new LookToMessage();
}
