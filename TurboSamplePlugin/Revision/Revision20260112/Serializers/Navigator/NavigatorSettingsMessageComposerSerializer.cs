using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Navigator;

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
