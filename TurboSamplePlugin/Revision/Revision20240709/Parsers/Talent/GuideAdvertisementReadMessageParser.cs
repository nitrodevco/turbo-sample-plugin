using Turbo.Primitives.Messages.Incoming.Talent;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Talent;

internal class GuideAdvertisementReadMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GuideAdvertisementReadMessage();
}
