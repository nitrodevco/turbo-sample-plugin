using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Chat;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Chat;

internal class RoomChatSettingsMessageComposerSerializer(int header)
    : AbstractSerializer<RoomChatSettingsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, RoomChatSettingsMessageComposer message)
    {
        //
    }
}
