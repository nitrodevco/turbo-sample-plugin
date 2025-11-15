using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Avatareffect;

internal class AvatarEffectSelectedMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectSelectedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AvatarEffectSelectedMessageComposer message
    )
    {
        //
    }
}
