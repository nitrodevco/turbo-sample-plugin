using Turbo.Primitives.Messages.Incoming.Help;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Help;

internal class GuideSessionMessageMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GuideSessionMessageMessage();
}
