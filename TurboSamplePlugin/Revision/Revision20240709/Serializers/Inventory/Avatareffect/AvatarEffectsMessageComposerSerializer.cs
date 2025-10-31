using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Avatareffect;

internal class AvatarEffectsMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, AvatarEffectsMessageComposer message)
    {
        //
    }
}
