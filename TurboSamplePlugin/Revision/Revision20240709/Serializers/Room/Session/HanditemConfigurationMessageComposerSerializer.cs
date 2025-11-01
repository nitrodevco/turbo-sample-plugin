using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Room.Session;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;

internal class HanditemConfigurationMessageComposerSerializer(int header)
    : AbstractSerializer<HanditemConfigurationMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        HanditemConfigurationMessageComposer message
    )
    {
        packet.WriteBoolean(message.IsHanditemControlBlocked);
    }
}
