using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class RoomAdPurchaseInfoEventMessageComposerSerializer(int header)
    : AbstractSerializer<RoomAdPurchaseInfoEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RoomAdPurchaseInfoEventMessageComposer message
    )
    {
        //
    }
}
