using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class BannedUsersFromRoomEventMessageComposerSerializer(int header)
    : AbstractSerializer<BannedUsersFromRoomEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BannedUsersFromRoomEventMessageComposer message
    )
    {
        //
    }
}
