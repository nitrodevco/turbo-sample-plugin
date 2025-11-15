using Turbo.Primitives.Messages.Outgoing.Notifications;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Notifications;

internal class RestoreClientMessageComposerSerializer(int header)
    : AbstractSerializer<RestoreClientMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RestoreClientMessageComposer message)
    {
        //
    }
}
