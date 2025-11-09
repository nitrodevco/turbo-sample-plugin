using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Navigator;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;

internal class FlatAccessDeniedMessageComposerSerializer(int header)
    : AbstractSerializer<FlatAccessDeniedMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, FlatAccessDeniedMessageComposer message)
    {
        packet.WriteInteger(message.RoomId).WriteString(message.Username);
    }
}
