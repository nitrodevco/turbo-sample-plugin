using Turbo.Primitives.Messages.Outgoing.Room.Action;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;

internal class AvatarEffectMessageComposerSerializer(int header)
    : AbstractSerializer<AvatarEffectMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, AvatarEffectMessageComposer message)
    {
        packet
            .WriteInteger(message.UserId)
            .WriteInteger(message.EffectId)
            .WriteInteger(message.DelayMilliseconds);
    }
}
