using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Hotlooks;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Hotlooks;

internal class GetHotLooksMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetHotLooksMessage();
}
