using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class TargetedOfferNotFoundEventMessageComposerSerializer(int header)
    : AbstractSerializer<TargetedOfferNotFoundEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TargetedOfferNotFoundEventMessageComposer message
    )
    {
        //
    }
}
