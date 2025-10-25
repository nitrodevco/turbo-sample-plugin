using Turbo.Contracts.Abstractions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Badges;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Badges;

public class GetBadgePointLimitsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetBadgePointLimitsMessage();
}
