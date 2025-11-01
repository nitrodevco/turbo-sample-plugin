using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class RoomEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomEventMessageComposer message)
    {
        //
    }
}
