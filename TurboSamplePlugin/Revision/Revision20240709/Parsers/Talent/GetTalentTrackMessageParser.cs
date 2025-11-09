using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Talent;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Talent;

internal class GetTalentTrackMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetTalentTrackMessage();
}
