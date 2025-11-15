using Turbo.Contracts.Abstractions;
using Turbo.Primitives.Messages.Incoming.Inventory.Badges;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Badges;

public class GetBadgePointLimitsMessageParser : IParser
{
    public IMessageEvent Parse(IClientPacket packet) => new GetBadgePointLimitsMessage();
}
