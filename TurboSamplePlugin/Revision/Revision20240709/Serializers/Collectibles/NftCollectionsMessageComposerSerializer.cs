using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class NftCollectionsMessageComposerSerializer(int header)
    : AbstractSerializer<NftCollectionsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, NftCollectionsMessageComposer message)
    {
        //
    }
}
