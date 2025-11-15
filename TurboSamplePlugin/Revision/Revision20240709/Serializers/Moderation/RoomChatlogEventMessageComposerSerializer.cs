using Turbo.Primitives.Messages.Outgoing.Moderation;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class RoomChatlogEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomChatlogEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomChatlogEventMessageComposer message)
    {
        //
    }
}
