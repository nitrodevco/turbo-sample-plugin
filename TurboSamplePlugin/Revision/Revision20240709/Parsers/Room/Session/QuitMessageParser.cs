using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Session;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Session;

internal class QuitMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new QuitMessage();
}
