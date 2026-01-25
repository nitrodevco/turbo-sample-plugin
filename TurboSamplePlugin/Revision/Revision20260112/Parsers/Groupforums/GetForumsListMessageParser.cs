using Turbo.Primitives.Messages.Incoming.Groupforums;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Groupforums;

internal class GetForumsListMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetForumsListMessage();
}
