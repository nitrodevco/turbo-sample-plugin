using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Badges;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Badges;

internal class IsBadgeRequestFulfilledEventMessageComposerSerializer(int header)
    : AbstractSerializer<IsBadgeRequestFulfilledEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        IsBadgeRequestFulfilledEventMessageComposer message
    )
    {
        //
    }
}
