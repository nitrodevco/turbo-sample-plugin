using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class InstantMessageErrorMessageSerializer(int header)
    : AbstractSerializer<InstantMessageErrorMessageComposer>(header)
{
    protected override void Serialize(
        IServerPacket packet,
        InstantMessageErrorMessageComposer message
    )
    {
        packet.WriteInteger((int)message.ErrorCode);
        packet.WriteInteger((int)message.PlayerId);
        packet.WriteString(message.Message);
    }
}
