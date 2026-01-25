using Turbo.Primitives.Messages.Outgoing.Inventory.Pets;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Pets;

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
