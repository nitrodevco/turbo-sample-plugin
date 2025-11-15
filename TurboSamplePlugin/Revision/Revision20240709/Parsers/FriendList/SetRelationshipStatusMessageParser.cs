using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;

internal class SetRelationshipStatusMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SetRelationshipStatusMessage();
}
