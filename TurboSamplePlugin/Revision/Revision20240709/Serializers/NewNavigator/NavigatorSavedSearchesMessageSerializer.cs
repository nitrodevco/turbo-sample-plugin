using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NavigatorSavedSearchesMessageSerializer(int header)
    : AbstractSerializer<NavigatorSavedSearchesMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NavigatorSavedSearchesMessage message
    )
    {
        //
    }
}
