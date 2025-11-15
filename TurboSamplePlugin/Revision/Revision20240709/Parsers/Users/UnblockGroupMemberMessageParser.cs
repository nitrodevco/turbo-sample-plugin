using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Users;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;

internal class UnblockGroupMemberMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UnblockGroupMemberMessage();
}
