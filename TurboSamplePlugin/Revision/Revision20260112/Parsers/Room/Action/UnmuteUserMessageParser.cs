using Turbo.Primitives.Messages.Incoming.Room.Action;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Room.Action;

internal class UnmuteUserMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new UnmuteUserMessage();
}
