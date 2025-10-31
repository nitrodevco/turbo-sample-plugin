using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Badges;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Badges;

internal class BadgePointLimitsEventMessageComposerSerializer(int header)
    : AbstractSerializer<BadgePointLimitsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BadgePointLimitsEventMessageComposer message
    )
    {
        //
    }
}
