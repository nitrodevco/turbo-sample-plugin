using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Action;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;

internal class SleepMessageComposerSerializer(int header)
    : AbstractSerializer<SleepMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, SleepMessageComposer message)
    {
        //
    }
}
