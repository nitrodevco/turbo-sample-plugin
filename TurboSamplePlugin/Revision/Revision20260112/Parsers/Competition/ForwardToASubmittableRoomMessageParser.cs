using Turbo.Primitives.Messages.Incoming.Competition;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Competition;

internal class ForwardToASubmittableRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ForwardToASubmittableRoomMessage();
}
