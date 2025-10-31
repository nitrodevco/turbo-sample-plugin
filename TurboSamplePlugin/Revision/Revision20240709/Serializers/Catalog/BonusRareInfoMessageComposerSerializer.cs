using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class BonusRareInfoMessageComposerSerializer(int header)
    : AbstractSerializer<BonusRareInfoMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, BonusRareInfoMessageComposer message)
    {
        //
    }
}
