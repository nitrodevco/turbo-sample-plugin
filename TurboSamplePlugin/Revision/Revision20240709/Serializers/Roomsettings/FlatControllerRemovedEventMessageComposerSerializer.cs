using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

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
