using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Pets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Pets;

internal class PetReceivedMessageComposerSerializer(int header)
    : AbstractSerializer<PetReceivedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PetReceivedMessageComposer message)
    {
        //
    }
}
