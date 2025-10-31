using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class HabboBroadcastMessageComposerSerializer(int header)
    : AbstractSerializer<HabboBroadcastMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, HabboBroadcastMessageComposer message)
    {
        //
    }
}
