using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Engine;
using Turbo.Primitives.Packets;
using Turbo.Primitives.Rooms.Enums;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Engine;

internal class MoveObjectMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new MoveObjectMessage
        {
            ObjectId = packet.PopInt(),
            X = packet.PopInt(),
            Y = packet.PopInt(),
            Rotation = (Rotation)packet.PopInt(),
        };
}
