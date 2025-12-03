using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class MessengerErrorMessageSerializer(int header)
    : AbstractSerializer<MessengerErrorMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, MessengerErrorMessageComposer message)
    {
        packet.WriteInteger(message.ClientMessageId);
        packet.WriteInteger((int)message.ErrorCode);
    }
}
