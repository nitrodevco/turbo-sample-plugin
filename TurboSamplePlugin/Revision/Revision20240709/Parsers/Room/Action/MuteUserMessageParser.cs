using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Action;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Action;

internal class MuteUserMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new MuteUserMessage();
}
