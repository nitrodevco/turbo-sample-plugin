using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;

public class FollowFriendMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new FollowFriendMessage { PlayerId = packet.PopInt() };
}
