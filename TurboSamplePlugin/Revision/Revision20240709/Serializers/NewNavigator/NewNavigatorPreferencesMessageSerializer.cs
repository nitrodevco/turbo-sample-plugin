using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;

internal class NewNavigatorPreferencesMessageSerializer(int header)
    : AbstractSerializer<NewNavigatorPreferencesMessage>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NewNavigatorPreferencesMessage message
    )
    {
        //
    }
}
