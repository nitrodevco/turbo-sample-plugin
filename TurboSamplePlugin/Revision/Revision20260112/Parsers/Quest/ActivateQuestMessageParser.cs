using Turbo.Primitives.Messages.Incoming.Quest;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Parsers.Quest;

internal class ActivateQuestMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new ActivateQuestMessage();
}
