using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class RoomVisitsEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomVisitsEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomVisitsEventMessageComposer message)
    {
        //
    }
}
