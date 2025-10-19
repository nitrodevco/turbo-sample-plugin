using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

public class GetUserFlatCatsParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetUserFlatCatsMessage();
}
