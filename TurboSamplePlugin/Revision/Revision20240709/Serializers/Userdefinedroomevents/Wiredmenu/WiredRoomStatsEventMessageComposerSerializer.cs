using Turbo.Primitives.Messages.Outgoing.Userdefinedroomevents.Wiredmenu;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Userdefinedroomevents.Wiredmenu;

internal class WiredRoomStatsEventMessageComposerSerializer(int header)
    : AbstractSerializer<WiredRoomStatsEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        WiredRoomStatsEventMessageComposer message
    )
    {
        //
    }
}
