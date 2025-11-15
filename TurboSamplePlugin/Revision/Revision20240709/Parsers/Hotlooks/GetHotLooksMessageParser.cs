using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Hotlooks;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Hotlooks;

internal class GetHotLooksMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetHotLooksMessage();
}
