using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class GuestRoomSearchResultMessageComposerSerializer(int header)
    : AbstractSerializer<GuestRoomSearchResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GuestRoomSearchResultMessageComposer message
    )
    {
        //
    }
}
