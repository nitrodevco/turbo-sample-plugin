using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class NavigatorSettingsMessageComposerSerializer(int header)
    : AbstractSerializer<NavigatorSettingsMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorSettingsMessageComposer message
    )
    {
        packet.WriteInteger(message.HomeRoomId).WriteInteger(message.RoomIdToEnter);
    }
}
