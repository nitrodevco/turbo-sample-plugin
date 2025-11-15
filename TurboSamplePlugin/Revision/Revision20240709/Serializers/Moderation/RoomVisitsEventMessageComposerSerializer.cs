using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class RoomVisitsEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomVisitsEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomVisitsEventMessageComposer message)
    {
        //
    }
}
