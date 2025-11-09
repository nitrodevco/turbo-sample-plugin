using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Pets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Pets;

internal class GetPetInfoMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetPetInfoMessage();
}
