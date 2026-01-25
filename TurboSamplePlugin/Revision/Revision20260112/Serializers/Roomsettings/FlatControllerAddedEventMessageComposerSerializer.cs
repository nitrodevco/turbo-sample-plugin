using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Roomsettings;

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
