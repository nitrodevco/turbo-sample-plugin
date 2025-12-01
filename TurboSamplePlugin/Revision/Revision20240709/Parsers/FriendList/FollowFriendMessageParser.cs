using Turbo.Primitives.Messages.Incoming.FriendList;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;

public class FollowFriendMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new FollowFriendMessage { PlayerId = packet.PopInt() };
}
