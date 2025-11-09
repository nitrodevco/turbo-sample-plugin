using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Layout;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Layout;

internal class GetOccupiedTilesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetOccupiedTilesMessage();
}
