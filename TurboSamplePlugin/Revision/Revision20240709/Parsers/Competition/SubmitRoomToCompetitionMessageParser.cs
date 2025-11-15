using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Competition;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Competition;

internal class SubmitRoomToCompetitionMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new SubmitRoomToCompetitionMessage();
}
