using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NavigatorLiftedRoomsMessageSerializer(int header)
    : AbstractSerializer<NavigatorLiftedRoomsMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorLiftedRoomsMessage message
    )
    {
        //
    }
}
