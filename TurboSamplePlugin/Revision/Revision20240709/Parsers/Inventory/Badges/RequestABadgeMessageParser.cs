using Turbo.Primitives.Messages.Incoming.Inventory.Badges;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Badges;

internal class RequestABadgeMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new RequestABadgeMessage();
}
