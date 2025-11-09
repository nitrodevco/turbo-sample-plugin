using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Quest;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Quest;

internal class AcceptQuestMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new AcceptQuestMessage();
}
