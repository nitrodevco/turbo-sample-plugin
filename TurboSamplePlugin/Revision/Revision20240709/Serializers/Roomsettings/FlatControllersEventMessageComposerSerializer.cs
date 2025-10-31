using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Roomsettings;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class FlatControllersEventMessageComposerSerializer(int header)
    : AbstractSerializer<FlatControllersEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        FlatControllersEventMessageComposer message
    )
    {
        //
    }
}
