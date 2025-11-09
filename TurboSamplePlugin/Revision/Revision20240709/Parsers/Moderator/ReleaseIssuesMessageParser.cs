using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Moderator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Moderator;

internal class ReleaseIssuesMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ReleaseIssuesMessage();
}
