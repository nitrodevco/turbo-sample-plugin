using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Engine;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Engine;

internal class MoveAvatarMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new MoveAvatarMessage { TargetX = packet.PopInt(), TargetY = packet.PopInt() };
}
