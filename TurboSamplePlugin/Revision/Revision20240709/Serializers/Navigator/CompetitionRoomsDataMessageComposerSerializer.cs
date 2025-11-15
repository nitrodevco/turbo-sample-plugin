using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class CompetitionRoomsDataMessageComposerSerializer(int header)
    : AbstractSerializer<CompetitionRoomsDataMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CompetitionRoomsDataMessageComposer message
    )
    {
        CompetitionRoomDataSerializer.Serialize(packet, message.RoomData);
    }
}
