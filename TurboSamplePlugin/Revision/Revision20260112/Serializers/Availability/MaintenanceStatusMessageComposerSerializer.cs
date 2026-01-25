using Turbo.Primitives.Messages.Outgoing.Availability;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Availability;

internal class MaintenanceStatusMessageComposerSerializer(int header)
    : AbstractSerializer<MaintenanceStatusMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MaintenanceStatusMessageComposer message
    )
    {
        //
    }
}
