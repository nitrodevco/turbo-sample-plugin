using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Catalog;

internal class ClubGiftInfoEventMessageComposerSerializer(int header)
    : AbstractSerializer<ClubGiftInfoEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ClubGiftInfoEventMessageComposer message
    )
    {
        //
    }
}
