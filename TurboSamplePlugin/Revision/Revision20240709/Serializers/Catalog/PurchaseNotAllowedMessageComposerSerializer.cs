using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class PurchaseNotAllowedMessageComposerSerializer(int header)
    : AbstractSerializer<PurchaseNotAllowedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        PurchaseNotAllowedMessageComposer message
    )
    {
        //
    }
}
