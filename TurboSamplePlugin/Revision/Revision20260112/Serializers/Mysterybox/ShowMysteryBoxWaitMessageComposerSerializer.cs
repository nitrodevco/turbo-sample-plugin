using Turbo.Primitives.Messages.Outgoing.Mysterybox;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Mysterybox;

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
