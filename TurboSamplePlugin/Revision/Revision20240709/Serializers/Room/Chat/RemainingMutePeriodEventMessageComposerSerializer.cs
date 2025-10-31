using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Chat;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Chat;

internal class RemainingMutePeriodEventMessageComposerSerializer(int header)
    : AbstractSerializer<RemainingMutePeriodEventMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        RemainingMutePeriodEventMessageComposer message
    )
    {
        //
    }
}
