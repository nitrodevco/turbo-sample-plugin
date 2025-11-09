using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Groupforums;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Groupforums;

internal class GetThreadMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetThreadMessage();
}
