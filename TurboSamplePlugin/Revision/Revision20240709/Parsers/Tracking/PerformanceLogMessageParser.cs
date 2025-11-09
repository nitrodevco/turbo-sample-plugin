using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Tracking;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;

internal class PerformanceLogMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PerformanceLogMessage
        {
            ElapsedTime = packet.PopInt(),
            UserAgent = packet.PopString(),
            FlashVersion = packet.PopString(),
            OS = packet.PopString(),
            Browser = packet.PopString(),
            IsDebugger = packet.PopBoolean(),
            MemoryUsage = packet.PopInt(),
            unknownField = packet.PopInt(),
            GarbageCollections = packet.PopInt(),
            AverageFrameRate = packet.PopInt(),
            SlowUpdates = packet.PopInt(),
        };
}
