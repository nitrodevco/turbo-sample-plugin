using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Room.Pets;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Pets;

internal class CustomizePetWithFurniMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CustomizePetWithFurniMessage();
}
