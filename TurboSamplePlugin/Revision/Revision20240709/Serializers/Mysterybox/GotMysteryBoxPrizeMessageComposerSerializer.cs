using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Mysterybox;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Mysterybox;

internal class GotMysteryBoxPrizeMessageComposerSerializer(int header)
    : AbstractSerializer<GotMysteryBoxPrizeMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        GotMysteryBoxPrizeMessageComposer message
    )
    {
        //
    }
}
