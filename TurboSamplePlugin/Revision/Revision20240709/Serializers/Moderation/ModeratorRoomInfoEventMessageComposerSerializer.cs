using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

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
