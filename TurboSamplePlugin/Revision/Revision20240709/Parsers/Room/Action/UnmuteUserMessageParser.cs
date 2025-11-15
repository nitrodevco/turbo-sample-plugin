using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Action;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Action;

internal class UnmuteUserMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UnmuteUserMessage();
}
