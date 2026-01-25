using Turbo.Primitives.Messages.Incoming.Userclassification;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Userclassification;

internal class RoomUsersClassificationMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RoomUsersClassificationMessage();
}
