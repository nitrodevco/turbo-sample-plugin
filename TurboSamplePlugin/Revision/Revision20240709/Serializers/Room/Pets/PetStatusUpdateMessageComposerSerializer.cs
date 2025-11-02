using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Pets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Pets;

internal class PetStatusUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<PetStatusUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PetStatusUpdateMessageComposer message)
    {
        //
    }
}
