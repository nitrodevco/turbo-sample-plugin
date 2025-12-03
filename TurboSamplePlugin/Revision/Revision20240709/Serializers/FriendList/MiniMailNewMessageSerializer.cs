using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Packets;

namespace TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;

internal class MiniMailNewMessageSerializer(int header)
    : AbstractSerializer<MiniMailNewMessageComposer>(header)
{
    protected override void Serialize(IServerPacket packet, MiniMailNewMessageComposer message)
    {
        //
    }
}
