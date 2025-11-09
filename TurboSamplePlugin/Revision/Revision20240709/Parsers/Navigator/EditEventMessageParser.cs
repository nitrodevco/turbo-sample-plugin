using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class EditEventMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new EditEventMessage
        {
            Id = packet.PopInt(),
            Name = packet.PopString(),
            Description = packet.PopString(),
        };
}
