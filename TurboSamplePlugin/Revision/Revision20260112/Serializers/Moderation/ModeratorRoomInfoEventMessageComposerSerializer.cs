using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Moderation;

internal class ModeratorRoomInfoEventMessageComposerSerializer(int header)
    : AbstractSerializer<ModeratorRoomInfoEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ModeratorRoomInfoEventMessageComposer message
    )
    {
        //
    }
}
