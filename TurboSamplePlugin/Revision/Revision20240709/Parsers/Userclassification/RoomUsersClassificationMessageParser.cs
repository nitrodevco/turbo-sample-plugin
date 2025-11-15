using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userclassification;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userclassification;

internal class RoomUsersClassificationMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RoomUsersClassificationMessage();
}
