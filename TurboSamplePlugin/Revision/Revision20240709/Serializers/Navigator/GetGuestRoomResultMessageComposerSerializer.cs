using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class GetGuestRoomResultMessageComposerSerializer(int header)
    : AbstractSerializer<GetGuestRoomResultMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GetGuestRoomResultMessageComposer message
    )
    {
        packet.WriteBoolean(message.EnterRoom);

        RoomSettingsSerializer.Serialize(packet, message.RoomSettings);

        packet
            .WriteBoolean(message.RoomForward)
            .WriteBoolean(message.StaffPick)
            .WriteBoolean(message.IsGroupMember)
            .WriteBoolean(message.AllInRoomMuted);

        // mod settings

        packet.WriteBoolean(message.CanMute);

        // chat settings
    }
}
