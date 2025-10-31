using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class CatalogPublishedMessageComposerSerializer(int header)
    : AbstractSerializer<CatalogPublishedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, CatalogPublishedMessageComposer message)
    {
        //
    }
}
