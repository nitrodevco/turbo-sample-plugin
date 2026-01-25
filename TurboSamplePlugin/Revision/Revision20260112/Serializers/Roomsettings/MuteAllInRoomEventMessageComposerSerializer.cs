using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Roomsettings;

internal class MuteAllInRoomEventMessageComposerSerializer(int header)
    : AbstractSerializer<MuteAllInRoomEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        MuteAllInRoomEventMessageComposer message
    )
    {
        //
    }
}
