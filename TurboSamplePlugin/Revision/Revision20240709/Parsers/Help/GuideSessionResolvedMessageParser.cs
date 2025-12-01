using Turbo.Primitives.Messages.Incoming.Help;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Help;

internal class GuideSessionResolvedMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GuideSessionResolvedMessage();
}
