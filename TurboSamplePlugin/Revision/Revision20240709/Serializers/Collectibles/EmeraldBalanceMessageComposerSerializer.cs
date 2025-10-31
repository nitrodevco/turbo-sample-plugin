using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Collectibles;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Collectibles;

internal class EmeraldBalanceMessageComposerSerializer(int header)
    : AbstractSerializer<EmeraldBalanceMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, EmeraldBalanceMessageComposer message)
    {
        //
    }
}
