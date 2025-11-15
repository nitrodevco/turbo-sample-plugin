using Turbo.Primitives.Messages.Outgoing.Room.Permissions;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Permissions;

internal class YouAreControllerMessageComposerSerializer(int header)
    : AbstractSerializer<YouAreControllerMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, YouAreControllerMessageComposer message)
    {
        //
    }
}
