using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Avatar;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Avatar;

internal class DanceMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new DanceMessage();
}
