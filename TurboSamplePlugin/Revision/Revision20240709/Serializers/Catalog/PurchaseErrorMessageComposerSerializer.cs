using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class PurchaseErrorMessageComposerSerializer(int header)
    : AbstractSerializer<PurchaseErrorMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, PurchaseErrorMessageComposer message)
    {
        //
    }
}
