using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Notifications;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class RestoreClientMessageComposerSerializer(int header)
    : AbstractSerializer<RestoreClientMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RestoreClientMessageComposer message)
    {
        //
    }
}
