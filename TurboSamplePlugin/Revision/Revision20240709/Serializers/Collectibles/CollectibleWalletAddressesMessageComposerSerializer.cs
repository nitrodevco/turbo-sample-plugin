using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

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
