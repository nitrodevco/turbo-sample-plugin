using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Register;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Register;

internal class UpdateFigureDataMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UpdateFigureDataMessage();
}
