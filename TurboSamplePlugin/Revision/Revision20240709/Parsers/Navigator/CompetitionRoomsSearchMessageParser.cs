using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;

internal class CompetitionRoomsSearchMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new CompetitionRoomsSearchMessage { GoalId = packet.PopInt(), PageIndex = packet.PopInt() };
}
