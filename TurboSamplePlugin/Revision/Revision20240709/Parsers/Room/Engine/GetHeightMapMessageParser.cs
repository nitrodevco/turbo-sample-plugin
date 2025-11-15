using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Engine;

internal class GetHeightMapMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetHeightMapMessage();
}
