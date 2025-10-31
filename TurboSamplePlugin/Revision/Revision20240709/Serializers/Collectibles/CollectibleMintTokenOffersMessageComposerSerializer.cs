using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class CollectibleMintTokenOffersMessageComposerSerializer(int header)
    : AbstractSerializer<CollectibleMintTokenOffersMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CollectibleMintTokenOffersMessageComposer message
    )
    {
        //
    }
}
