using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Avatareffect;

internal class AvatarEffectExpiredMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectExpiredMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AvatarEffectExpiredMessageComposer message
    )
    {
        //
    }
}
