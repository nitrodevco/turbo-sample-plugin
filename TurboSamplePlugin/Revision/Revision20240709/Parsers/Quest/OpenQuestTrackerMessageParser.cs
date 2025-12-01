using Turbo.Primitives.Messages.Incoming.Quest;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Quest;

internal class OpenQuestTrackerMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new OpenQuestTrackerMessage();
}
