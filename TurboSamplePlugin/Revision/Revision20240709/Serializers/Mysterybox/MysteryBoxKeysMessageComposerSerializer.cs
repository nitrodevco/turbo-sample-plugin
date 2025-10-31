using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Mysterybox;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Mysterybox;

internal class MysteryBoxKeysMessageComposerSerializer(int header)
    : AbstractSerializer<MysteryBoxKeysMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, MysteryBoxKeysMessageComposer message)
    {
        //
    }
}
