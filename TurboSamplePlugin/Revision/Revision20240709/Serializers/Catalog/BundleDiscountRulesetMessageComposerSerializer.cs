using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog.Data;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class BundleDiscountRulesetMessageComposerSerializer(int header)
    : AbstractSerializer<BundleDiscountRulesetMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        BundleDiscountRulesetMessageComposer message
    )
    {
        BundleDiscountRulesetSnapshotSerializer.Serialize(packet, message.BundleDiscountRuleset);
    }
}
