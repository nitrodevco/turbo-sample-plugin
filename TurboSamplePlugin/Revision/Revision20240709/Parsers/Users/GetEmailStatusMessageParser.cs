using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;

internal class GetEmailStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetEmailStatusMessage();
}
