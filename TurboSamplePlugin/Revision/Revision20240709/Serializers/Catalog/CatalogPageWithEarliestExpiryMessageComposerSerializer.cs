using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class CatalogPageWithEarliestExpiryMessageComposerSerializer(int header)
    : AbstractSerializer<CatalogPageWithEarliestExpiryMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CatalogPageWithEarliestExpiryMessageComposer message
    )
    {
        //
    }
}
