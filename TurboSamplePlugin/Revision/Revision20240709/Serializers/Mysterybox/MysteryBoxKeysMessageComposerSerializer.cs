using Turbo.Primitives.Messages.Outgoing.Mysterybox;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Mysterybox;

internal class MysteryBoxKeysMessageComposerSerializer(int header)
    : AbstractSerializer<MysteryBoxKeysMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, MysteryBoxKeysMessageComposer message)
    {
        //
    }
}
