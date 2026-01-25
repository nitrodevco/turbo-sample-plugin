using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog;

internal class LimitedEditionSoldOutEventMessageComposerSerializer(int header)
    : AbstractSerializer<LimitedEditionSoldOutEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        LimitedEditionSoldOutEventMessageComposer message
    )
    {
        //
    }
}
