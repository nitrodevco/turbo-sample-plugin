using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Furni;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Furni;

internal class RequestFurniInventoryWhenNotInRoomMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new RequestFurniInventoryWhenNotInRoomMessage();
}
