using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Pets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Pets;

internal class NestBreedingSuccessEventMessageComposerSerializer(int header)
    : AbstractSerializer<NestBreedingSuccessEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        NestBreedingSuccessEventMessageComposer message
    )
    {
        //
    }
}
