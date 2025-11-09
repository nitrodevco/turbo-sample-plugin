using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.GroupForums;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.GroupForums;

internal class GetMessagesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetMessagesMessage();
}
