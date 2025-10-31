using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class ClubGiftSelectedEventMessageComposerSerializer(int header)
    : AbstractSerializer<ClubGiftSelectedEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ClubGiftSelectedEventMessageComposer message
    )
    {
        //
    }
}
