using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Chat;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Chat;

internal class WhisperMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new WhisperMessage();
}
