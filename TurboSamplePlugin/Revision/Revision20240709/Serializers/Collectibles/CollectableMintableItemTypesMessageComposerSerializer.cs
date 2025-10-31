using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class CollectableMintableItemTypesMessageComposerSerializer(int header)
    : AbstractSerializer<CollectableMintableItemTypesMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CollectableMintableItemTypesMessageComposer message
    )
    {
        //
    }
}
