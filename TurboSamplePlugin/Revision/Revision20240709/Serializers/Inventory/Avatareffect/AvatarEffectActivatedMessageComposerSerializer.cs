using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Avatareffect;

internal class AvatarEffectActivatedMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectActivatedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AvatarEffectActivatedMessageComposer message
    )
    {
        //
    }
}
