using Turbo.Primitives.Messages.Incoming.Catalog;
using Turbo.Primitives.Networking;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;

internal class PurchaseVipMembershipExtensionMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) =>
        new PurchaseVipMembershipExtensionMessage { OfferId = packet.PopInt() };
}
