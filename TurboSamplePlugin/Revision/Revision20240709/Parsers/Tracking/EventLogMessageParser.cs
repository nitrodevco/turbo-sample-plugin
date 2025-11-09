using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Tracking;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;

internal class EventLogMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new EventLogMessage
        {
            Event = packet.PopString(),
            Data = packet.PopString(),
            Action = packet.PopString(),
            ExtraString = packet.PopString(),
            ExtraInt = packet.PopInt(),
        };
}
