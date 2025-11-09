using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Pets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Pets;

internal class CancelPetBreedingMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new CancelPetBreedingMessage();
}
