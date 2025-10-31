using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Mysterybox;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Mysterybox;

internal class CancelMysteryBoxWaitMessageComposerSerializer(int header)
    : AbstractSerializer<CancelMysteryBoxWaitMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        CancelMysteryBoxWaitMessageComposer message
    )
    {
        //
    }
}
