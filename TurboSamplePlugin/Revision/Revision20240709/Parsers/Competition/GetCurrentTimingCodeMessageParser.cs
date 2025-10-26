using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Competition;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Competition;

internal class GetCurrentTimingCodeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetCurrentTimingCodeMessage { SlotConfig = packet.PopString() };
}
