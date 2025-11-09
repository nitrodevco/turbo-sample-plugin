using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Furni;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Furni;

internal class RequestRoomPropertySetMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RequestRoomPropertySetMessage();
}
