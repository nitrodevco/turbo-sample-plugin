using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Availability;

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
