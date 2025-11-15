using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class EmeraldBalanceMessageComposerSerializer(int header)
    : AbstractSerializer<EmeraldBalanceMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, EmeraldBalanceMessageComposer message)
    {
        //
    }
}
