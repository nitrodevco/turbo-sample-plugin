using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Collectibles;

internal class CollectibleWalletAddressesMessageComposerSerializer(int header)
    : AbstractSerializer<CollectibleWalletAddressesMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CollectibleWalletAddressesMessageComposer message
    )
    {
        //
    }
}
