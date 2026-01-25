using Turbo.Primitives.Messages.Incoming.Moderator;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Moderator;

internal class GetRoomVisitsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetRoomVisitsMessage();
}
