using Turbo.Primitives.Messages.Incoming.Poll;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Poll;

internal class PollStartMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new PollStartMessage();
}
