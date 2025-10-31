using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class TargetedOfferEventMessageComposerSerializer(int header)
    : AbstractSerializer<TargetedOfferEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        TargetedOfferEventMessageComposer message
    )
    {
        //
    }
}
