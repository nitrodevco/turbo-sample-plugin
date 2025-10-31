using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class AreaHideMessageComposerSerializer(int header)
    : AbstractSerializer<AreaHideMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, AreaHideMessageComposer message)
    {
        //
    }
}
