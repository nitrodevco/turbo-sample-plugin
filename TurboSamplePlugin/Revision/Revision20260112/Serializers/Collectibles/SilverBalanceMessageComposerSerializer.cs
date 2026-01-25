using Turbo.Primitives.Messages.Outgoing.Collectibles;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Collectibles;

internal class SilverBalanceMessageComposerSerializer(int header)
    : AbstractSerializer<SilverBalanceMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, SilverBalanceMessageComposer message)
    {
        packet.WriteInteger(message.SilverBalance);
    }
}
