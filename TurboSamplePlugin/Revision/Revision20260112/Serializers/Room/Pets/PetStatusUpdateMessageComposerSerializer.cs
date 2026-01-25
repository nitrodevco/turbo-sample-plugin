using Turbo.Primitives.Messages.Outgoing.Room.Pets;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Room.Pets;

internal class PetStatusUpdateMessageComposerSerializer(int header)
    : AbstractSerializer<PetStatusUpdateMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PetStatusUpdateMessageComposer message)
    {
        //
    }
}
