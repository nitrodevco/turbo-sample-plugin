using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Action;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;

internal class DanceMessageComposerSerializer(int header)
    : AbstractSerializer<DanceMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, DanceMessageComposer message)
    {
        packet.WriteInteger(message.UserId).WriteInteger(message.DanceStyle);
    }
}
