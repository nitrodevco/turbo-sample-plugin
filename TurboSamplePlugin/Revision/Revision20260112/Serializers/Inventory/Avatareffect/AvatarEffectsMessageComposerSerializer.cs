using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Avatareffect.Data;

namespace TurboSamplePlugin.Revision.Revision20260112.Serializers.Inventory.Avatareffect;

internal class AvatarEffectsMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectsMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, AvatarEffectsMessageComposer message)
    {
        packet.WriteInteger(message.Effects.Length);

        foreach (var effect in message.Effects)
            AvatarEffectSerializer.Serialize(packet, effect);
    }
}
