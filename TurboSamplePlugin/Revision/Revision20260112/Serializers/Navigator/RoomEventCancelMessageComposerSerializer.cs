using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Navigator;

internal class RoomEventCancelMessageComposerSerializer(int header)
    : AbstractSerializer<RoomEventCancelMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomEventCancelMessageComposer message)
    {
        //
    }
}
