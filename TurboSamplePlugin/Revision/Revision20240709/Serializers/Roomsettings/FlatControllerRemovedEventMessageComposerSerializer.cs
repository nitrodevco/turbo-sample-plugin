using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class FlatControllerRemovedEventMessageComposerSerializer(int header)
    : AbstractSerializer<FlatControllerRemovedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FlatControllerRemovedEventMessageComposer message
    )
    {
        //
    }
}
