using Turbo.Primitives.Messages.Outgoing.Room.Permissions;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Permissions;

internal class YouAreOwnerMessageComposerSerializer(int header)
    : AbstractSerializer<YouAreOwnerMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, YouAreOwnerMessageComposer message)
    {
        packet.WriteInteger(message.RoomId);
    }
}
