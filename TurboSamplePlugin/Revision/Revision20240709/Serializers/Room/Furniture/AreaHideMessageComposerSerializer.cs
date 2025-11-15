using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;

internal class AreaHideMessageComposerSerializer(int header)
    : AbstractSerializer<AreaHideMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, AreaHideMessageComposer message)
    {
        AreaHideDataSerializer.Serialize(packet, message.AreaHideData);
    }
}
