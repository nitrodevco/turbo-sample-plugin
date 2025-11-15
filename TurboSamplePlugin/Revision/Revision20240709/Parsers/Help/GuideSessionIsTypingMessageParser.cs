using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Help;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Help;

internal class GuideSessionIsTypingMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GuideSessionIsTypingMessage();
}
