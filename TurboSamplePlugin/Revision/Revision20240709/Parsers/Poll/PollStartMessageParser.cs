using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Poll;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Poll;

internal class PollStartMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new PollStartMessage();
}
