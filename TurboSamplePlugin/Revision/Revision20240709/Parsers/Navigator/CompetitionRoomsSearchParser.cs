using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

public class CompetitionRoomsSearchParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new CompetitionRoomsSearchMessage { GoalId = packet.PopInt(), PageIndex = packet.PopInt() };
}
