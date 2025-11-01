using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class DoorbellMessageComposerSerializer(int header)
    : AbstractSerializer<DoorbellMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, DoorbellMessageComposer message)
    {
        packet.WriteString(message.Username);
    }
}
