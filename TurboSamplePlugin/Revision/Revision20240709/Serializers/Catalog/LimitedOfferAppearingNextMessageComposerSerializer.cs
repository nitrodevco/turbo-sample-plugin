using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class LimitedOfferAppearingNextMessageComposerSerializer(int header)
    : AbstractSerializer<LimitedOfferAppearingNextMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        LimitedOfferAppearingNextMessageComposer message
    )
    {
        //
    }
}
