using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Engine;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Engine;

internal class SetItemDataMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SetItemDataMessage();
}
