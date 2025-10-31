using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Mysterybox;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Mysterybox;

internal class ShowMysteryBoxWaitMessageComposerSerializer(int header)
    : AbstractSerializer<ShowMysteryBoxWaitMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        ShowMysteryBoxWaitMessageComposer message
    )
    {
        //
    }
}
