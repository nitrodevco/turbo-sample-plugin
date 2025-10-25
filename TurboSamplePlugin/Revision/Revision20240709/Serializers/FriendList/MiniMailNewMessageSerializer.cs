using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.FriendList;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class MiniMailNewMessageSerializer(int header)
    : AbstractSerializer<MiniMailNewMessage>(header)
{
    protected override void Serialize(IServerPacket packet, MiniMailNewMessage message)
    {
        //
    }
}
