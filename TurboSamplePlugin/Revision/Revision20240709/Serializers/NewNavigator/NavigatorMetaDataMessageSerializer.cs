using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NavigatorMetaDataMessageSerializer(int header)
    : AbstractSerializer<NavigatorMetaDataMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorMetaDataMessage message
    )
    {
        //
    }
}
