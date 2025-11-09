using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Sound;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Sound;

internal class GetOfficialSongIdMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetOfficialSongIdMessage();
}
