using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Userclassification;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Userclassification;

internal class PeerUsersClassificationMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new PeerUsersClassificationMessage();
}
