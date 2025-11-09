using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Nux;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Nux;

internal class SelectInitialRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SelectInitialRoomMessage();
}
