using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Avatareffect;

internal class AvatarEffectAddedMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectAddedMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        AvatarEffectAddedMessageComposer message
    )
    {
        //
    }
}
