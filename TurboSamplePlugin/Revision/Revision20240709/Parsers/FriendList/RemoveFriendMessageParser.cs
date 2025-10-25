using System.Collections.Generic;
using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;

public class RemoveFriendMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet)
    {
        var friendIds = new List<int>();

        var totalFriends = packet.PopInt();

        for (var i = 0; i < totalFriends; i++)
        {
            friendIds.Add(packet.PopInt());
        }

        return new RemoveFriendMessage { FriendIds = friendIds };
    }
}
