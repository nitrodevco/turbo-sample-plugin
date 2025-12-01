using Turbo.Primitives.Messages.Incoming.Help;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Help;

internal class PostQuizAnswersMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new PostQuizAnswersMessage();
}
