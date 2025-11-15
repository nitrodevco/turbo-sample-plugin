using Turbo.Primitives.Messages.Outgoing.Roomsettings;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Roomsettings;

internal class NoSuchFlatEventMessageComposerSerializer(int header)
    : AbstractSerializer<NoSuchFlatEventMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, NoSuchFlatEventMessageComposer message)
    {
        //
    }
}
