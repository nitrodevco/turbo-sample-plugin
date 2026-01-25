using Turbo.Primitives.Messages.Incoming.FriendList;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.FriendList;

internal class SetRelationshipStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SetRelationshipStatusMessage();
}
