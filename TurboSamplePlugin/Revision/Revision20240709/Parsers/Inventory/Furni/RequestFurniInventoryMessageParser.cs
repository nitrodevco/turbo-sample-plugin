using Turbo.Primitives.Messages.Incoming.Inventory.Furni;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Furni;

internal class RequestFurniInventoryMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RequestFurniInventoryMessage();
}
