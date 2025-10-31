using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Moderation;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Moderation;

internal class RoomChatlogEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomChatlogEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomChatlogEventMessageComposer message)
    {
        //
    }
}
