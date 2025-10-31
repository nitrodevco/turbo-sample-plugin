using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class ActivityPointsMessageComposerSerializer(int header)
    : AbstractSerializer<ActivityPointsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, ActivityPointsMessageComposer message)
    {
        //
    }
}
