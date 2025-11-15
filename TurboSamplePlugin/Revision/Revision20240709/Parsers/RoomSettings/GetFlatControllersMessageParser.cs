using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.RoomSettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;

internal class GetFlatControllersMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new GetFlatControllersMessage { RoomId = packet.PopInt() };
}
