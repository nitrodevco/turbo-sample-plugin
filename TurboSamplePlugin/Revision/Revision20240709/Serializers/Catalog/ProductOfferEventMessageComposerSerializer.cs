using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class ProductOfferEventMessageComposerSerializer(int header)
    : AbstractSerializer<ProductOfferEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ProductOfferEventMessageComposer message
    )
    {
        //
    }
}
