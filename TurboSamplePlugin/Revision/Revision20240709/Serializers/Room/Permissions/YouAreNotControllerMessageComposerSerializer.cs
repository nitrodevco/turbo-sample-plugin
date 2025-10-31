using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Permissions;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Permissions;

internal class YouAreNotControllerMessageComposerSerializer(int header)
    : AbstractSerializer<YouAreNotControllerMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        YouAreNotControllerMessageComposer message
    )
    {
        //
    }
}
