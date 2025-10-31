using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Catalog;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;

internal class NotEnoughBalanceMessageComposerSerializer(int header)
    : AbstractSerializer<NotEnoughBalanceMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, NotEnoughBalanceMessageComposer message)
    {
        //
    }
}
