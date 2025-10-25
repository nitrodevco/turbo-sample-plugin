using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Users;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;

public class GetMOTDParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetMOTDMessage();
}
