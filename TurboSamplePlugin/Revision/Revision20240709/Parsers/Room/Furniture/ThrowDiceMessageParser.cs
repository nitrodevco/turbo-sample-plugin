using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Furniture;

internal class ThrowDiceMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ThrowDiceMessage();
}
