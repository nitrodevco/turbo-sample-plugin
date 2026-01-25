using Turbo.Primitives.Messages.Outgoing.Room.Chat;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Chat;

internal class RoomFilterSettingsMessageComposerSerializer(int header)
    : AbstractSerializer<RoomFilterSettingsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomFilterSettingsMessageComposer message
    )
    {
        //
    }
}
