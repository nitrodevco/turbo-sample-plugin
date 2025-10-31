using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class FlatControllerAddedEventMessageComposerSerializer(int header)
    : AbstractSerializer<FlatControllerAddedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FlatControllerAddedEventMessageComposer message
    )
    {
        //
    }
}
