using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Chat;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Chat;

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
