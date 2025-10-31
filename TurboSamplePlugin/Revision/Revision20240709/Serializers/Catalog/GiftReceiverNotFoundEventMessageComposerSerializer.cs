using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class GiftReceiverNotFoundEventMessageComposerSerializer(int header)
    : AbstractSerializer<GiftReceiverNotFoundEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GiftReceiverNotFoundEventMessageComposer message
    )
    {
        //
    }
}
