using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect;
using Turbo.Primitives.Messages.Outgoing.Inventory.Avatareffect.Data;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Inventory.Avatareffect;

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
