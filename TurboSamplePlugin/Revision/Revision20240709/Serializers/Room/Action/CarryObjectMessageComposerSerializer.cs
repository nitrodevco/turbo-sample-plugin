using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Action;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;

internal class CarryObjectMessageComposerSerializer(int header)
    : AbstractSerializer<CarryObjectMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CarryObjectMessageComposer message)
    {
        //
    }
}
