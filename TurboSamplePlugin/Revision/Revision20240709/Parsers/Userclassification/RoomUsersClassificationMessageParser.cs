using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userclassification;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userclassification;

internal class RoomUsersClassificationMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RoomUsersClassificationMessage();
}
