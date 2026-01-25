using Turbo.Primitives.Messages.Incoming.Talent;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Talent;

internal class GetTalentTrackMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetTalentTrackMessage();
}
